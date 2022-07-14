using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PassWord_Maker
{
	public partial class PasswordMaker:Form
	{
		// 保存ボタン押下の確認用
		private bool bUntilSave = false;
		// データを保持するテーブル
		private DataTable dtPass = new DataTable();

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PasswordMaker()
		{
			InitializeComponent();
			// ウィンドウタイトル
			this.Text = Properties.Resources.WindowTitle;
			// アイコン設定
			this.Icon = Properties.Resources.PMicon2;
			// ファイル名を取得する
			// ※このファイル名は決め打ちのファイルパスであるため、ユーザからは変更しない
			string filePath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents" + Properties.Resources.DefaultDirectory;
			string fullPath = filePath + Properties.Resources.DefaultFileName;
			// ファイル、ディレクトリの存在確認
			if(File.Exists(fullPath) && Directory.Exists(filePath))
			{
				// 存在する場合、表示用にファイルを読み込む
				dtPass = createDTable(fullPath);
				dataGridPass.DataSource = dtPass;
			}
			else
			{
				// ディレクトリ作成
				Directory.CreateDirectory(filePath);
				// ファイル出力
				File.WriteAllText(fullPath, "", Encoding.UTF8);
			}
			// パスワードの表示を決定する
			GridViewControl();
		}

		/// <summary>
		/// パスワード生成ボタン押下時の処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PassWordMake_Button_Click(object sender, EventArgs e)
		{

			// 将来の改造用
			string st1 = "QWERTYUIOPASDFGHJKLZXCVBNM";
			string st2 = "qwertyuiopasdfghjklzxcvbnm";
			string st3 = "0123456789";

			// パスワード生成用の文字列
			string stWords = st1 + st2 + st3;
			// 生成したパスワードを返すための文字列
			StringBuilder sb = new StringBuilder();

			// 生成するパスワードの文字数を取得する。
			int num = Decimal.ToInt32(numericUpDown1.Value);

			// パスワード用にランダムな文字列を生成する。
			sb.Append(RandomString(num, stWords));

			// パスワードを画面に出力する。
			textBoxPass.Text = sb.ToString();
		}

		/// <summary>
		/// ファイル出力ボタン押下時の処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fileSaveButton_Click(object sender, EventArgs e)
		{
			// ファイル保存ダイアログを用意する
			SaveFileDialog sfPassSave = new SaveFileDialog
			{
				// ファイル保存ダイアログを初期化する
				Title = Properties.Resources.SaveTitle,
				FileName = @"password.csv",
				Filter = Properties.Resources.SaveFilter
			};
			DialogResult result = sfPassSave.ShowDialog();

			if(result == DialogResult.OK)
			{
				// 保存先のフルパスを保存処理に渡す
				string filename = sfPassSave.FileName;
				SavePass(filename, true);
			}
			sfPassSave.Dispose();
		}

		/// <summary>
		/// パスワードの表示のチェックボックス操作時の処理(未実装)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkPassVisible_CheckedChanged(object sender, EventArgs e)
		{
			GridViewControl();
		}

		/// <summary>
		/// 登録ボタン押下時の処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRegistration_Click(object sender, EventArgs e)
		{
			RegistrationPass();
		}

		/// <summary>
		/// 削除ボタン押下時の処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			foreach(DataGridViewRow row in dataGridPass.SelectedRows)
			{
				dataGridPass.Rows.Remove(row);
			}
			// データテーブルに削除後のデータを格納
			dtPass = (DataTable)dataGridPass.DataSource;
			// 未保存フラグを立てる
			bUntilSave = true;
		}

		/// <summary>
		/// パスワード表示のテキストボックスでEnterキーを押したときの処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				// 登録処理関数を呼び出す
				RegistrationPass();
			}
		}

		/// <summary>
		/// 保存ボタン押下時の処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSavePass_Click(object sender,EventArgs e)
		{
			string pathFile = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents" + Properties.Resources.DefaultDirectory;
			string fullPath = pathFile + Properties.Resources.DefaultFileName;
			// ファイル保存処理を呼び出し
			SavePass(fullPath, true);

			bUntilSave = false;
		}

		/// <summary>
		/// セルをダブルクリックしたときの処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridPass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// セルを選択したときにヘッダーを選択していないか確認する。
			if(e.RowIndex >= 0)
			{
				// 選択したセルの列情報を取得する
				DataGridViewRow dgRows = dataGridPass.Rows[e.RowIndex];

				// 各TextBoxに情報を入力する
				textBoxService.Text = dgRows.Cells[0].Value.ToString();
				textBoxUser.Text = dgRows.Cells[1].Value.ToString();
				textBoxPass.Text = dgRows.Cells[2].Value.ToString();
			}
		}

		/// <summary>
		/// パスワードの操作可否を操作するチェックボックス
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkTextBoxControl_CheckedChanged(object sender, EventArgs e)
		{
			if(checkTextBoxControl.Checked == true)
			{
				textBoxPass.ReadOnly = false;
			}
			else
			{
				textBoxPass.ReadOnly = true;
			}
		}

		/// <summary>
		/// フォームを閉じるときの処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(bUntilSave == true)
			{
				DialogResult result = MessageBox.Show("パスワードを保存しますか？", "PassWordMaker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(result == DialogResult.Yes)
				{
					string pathFile = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents" + Properties.Resources.DefaultDirectory;
					string fullPath = pathFile + Properties.Resources.DefaultFileName;
					// ファイル保存処理を呼び出し
					SavePass(fullPath, true);
				}
				else
				{
					DialogResult r = MessageBox.Show("パスワードを保存せずに終了しますか？", "PassWordMaker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(r == DialogResult.No)
					{
						e.Cancel = true;
					}
				}
			}
		}

		/// <summary>
		/// テキストボックスに入力されている内容をクリアする
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearBox_Click(object sender, EventArgs e)
		{
			// テキストボックスに何か入力されている場合、テキストボックスをクリアする。
			if(!String.IsNullOrEmpty(textBoxService.Text) || !String.IsNullOrEmpty(textBoxUser.Text) || !String.IsNullOrEmpty(textBoxPass.Text))
			{
				textBoxService.Text = "";
				textBoxUser.Text = "";
				textBoxPass.Text = "";
			}
		}
		/**********************************************************************************************************************************************/

		////////////////////////////////////////////////////////////////
		// ランダムな文字列を生成する関数
		// 引数1	：出力する文字数
		// 引数2	：パスワード生成に使用する文字列
		//
		// 戻り値	：ランダムに生成した文字列
		////////////////////////////////////////////////////////////////
		private string RandomString(int length, string valid)
		{
			StringBuilder sbRet = new StringBuilder();
			using(RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				// uintのバイトサイズのバッファーを用意する
				byte[] bRndBuffer = new byte[sizeof(uint)];

				while(length-- > 0)
				{
					// Byte型のバッファーに乱数を格納する
					rng.GetBytes(bRndBuffer);
					// 生成した乱数をuint型に変換する
					uint uiRnd = BitConverter.ToUInt32(bRndBuffer,0);
					// 乱数を、パスワード生成に使用する文字列の文字数で剰余計算し、その余りで使用する文字を決定する。
					sbRet.Append(valid[(int)(uiRnd % (uint)valid.Length)]);
				}
			}

			return sbRet.ToString();
		}
		////////////////////////////////////////////////////////////////
		// パスワードの表示可否をコントロールする関数
		// 引数		：なし
		//
		// 戻り値	：ランダムに生成した文字列
		////////////////////////////////////////////////////////////////
		private void GridViewControl()
		{
			// パスワード表示の可否を確認する
			if(checkPassVisible.Checked == true)
			{
				// パスワード行を表示する
				dataGridPass.Columns[2].Visible = true;
				// Password行を非表示にする
				dataGridPass.Columns[3].Visible = false;
			}
			else
			{
				// パスワード行を非表示にする
				dataGridPass.Columns[2].Visible = false;
				// Password行を表示する(マスクを表示)
				dataGridPass.Columns[3].Visible = true;
			}
		}

		////////////////////////////////////////////////////////////////
		// 保存ボタン押下時のファイル保存処理関数
		// 引数		：デフォルトの保存先のフルパス
		//
		// 戻り値	：なし
		////////////////////////////////////////////////////////////////
		private void SavePass(string fullPath, bool isHeader)
		{
			StringBuilder sbRet = new StringBuilder();
			// ヘッダーが必要か確認する
			if(isHeader == true)
			{
				// csvファイルのヘッダーを作成する
				sbRet.AppendLine("サービス,ユーザ名,パスワード");
			}

			try
			{
				for(int iRow = 0; iRow < dtPass.Rows.Count; iRow++)
				{
					DataGridViewRow dRows = dataGridPass.Rows[iRow];
					StringBuilder sbBuffer = new StringBuilder();

					// 「Password」行の情報を取得しないように「-1」する
					for(int iCol = 0; iCol < dRows.Cells.Count - 1; iCol++)
					{
						sbBuffer.Append(dRows.Cells[iCol].Value.ToString() + ",");
					}
					sbRet.AppendLine(sbBuffer.ToString(0, (sbBuffer.Length - 1)));
				}
				StreamWriter txtFile = new StreamWriter(fullPath, false, Encoding.UTF8);
				txtFile.Write(sbRet.ToString());
				txtFile.Close();
				MessageBox.Show("パスワードを保存しました。", "ファイル保存", MessageBoxButtons.OK);
			}
			catch(IOException)
			{
				MessageBox.Show("パスワードの保存に失敗しました。", "エラーメッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		////////////////////////////////////////////////////////////////
		// 登録ボタン押下時の処理関数
		// 引数		：なし
		//
		// 戻り値	：なし
		////////////////////////////////////////////////////////////////
		private void RegistrationPass()
		{
			if(!string.IsNullOrEmpty(textBoxPass.Text))
			{
				// データテーブルを更新
				dtPass.Rows.Add(textBoxService.Text, textBoxUser.Text, textBoxPass.Text, "***");

				// 入力項目をクリア
				textBoxService.Text = "";
				textBoxUser.Text = "";
				textBoxPass.Text = "";
				checkTextBoxControl.Checked = false;

				// 保存状態をtrueに変更
				bUntilSave = true;
			}
			else
			{
				MessageBox.Show("パスワードが作成されていません。", "PasswordMaker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		////////////////////////////////////////////////////////////////
		// 保存してあるパスワードファイルの読み込み処理
		// 引数		：なし
		//
		// 戻り値	：なし
		////////////////////////////////////////////////////////////////
		private DataTable createDTable(string filePath)
		{
			DataTable dtRet = new DataTable();
			string mask = Properties.Resources.Mask;

			dtRet.Columns.Add("サービス");
			dtRet.Columns.Add("ユーザ名");
			dtRet.Columns.Add("パスワード");
			dtRet.Columns.Add("Password");

			try
			{
				string[] lines = File.ReadAllLines(filePath);
				foreach(string line in lines)
				{
					// 最初の列がヘッダーの場合、データではないため読み込み対象外とする
					if(line.Equals("サービス,ユーザ名,パスワード", StringComparison.Ordinal))
					{
						continue;
					}
					string sData = line + ",***";
					string[] items = sData.Split(',');

					dtRet.Rows.Add(items);
				};
			}
			catch(IOException)
			{
				MessageBox.Show("ファイルを読み込めませんでした。", "PasswordMaker", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return dtRet;
		}
	}
}
