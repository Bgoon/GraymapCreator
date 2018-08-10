using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace GraymapCreator {
	public partial class MainForm : Form {
		//탑바
		private bool isDragging;
		private Point dragStartPoint;
		private Point originPos;

		//비트맵
		private bool isDrawing;
		private Bitmap bitmap;
		private Point drawStartPoint;
		Graphics graphics;


		public MainForm() {
			InitializeComponent();
		}
		private void OnLoad(object sender, EventArgs e) {
			Init();
			SetEvent();
		}
		private void Init() {
			Size = new Size(112, 182);

			//비트맵 생성
			bitmap = new Bitmap(28, 28);
			ImageView.Image = bitmap;

			graphics = Graphics.FromImage(bitmap);
			graphics.Clear(Color.White);
			ImageView.Invalidate();
		}
		private void SetEvent() {
			ExitBtn.Click += OnExitBtnClick;

			TopBar.MouseDown += OnTopBarMouseDown;
			TopBar.MouseMove += OnTopBarMouseMove;
			TopBar.MouseUp += OnTopBarMouseUp;

			ImageView.MouseDown += OnImageMouseDown;
			ImageView.MouseMove += OnImageMouseMove;
			ImageView.MouseUp += OnImageMouseUp;

			GenerateBtn.Click += OnGenerateBtnClick;
			RedrawBtn.Click += OnRedrawBtnClick;
		}

		private void OnGenerateBtnClick(object sender, EventArgs e) {
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string fileName = desktopPath + "/그레이 맵_";
			int num = 1;

			for (; ; ++num) {
				if (!File.Exists(fileName + num + ".png") &&
					!File.Exists(fileName + num + ".gray")) {
					break;
				}
			}
			fileName += num;

			//비트맵 저장
			bitmap.Save(fileName + ".png", ImageFormat.Png);
			//비트 저장
			byte bit;
			using (FileStream fileStream = new FileStream(fileName + ".gray", FileMode.Create, FileAccess.ReadWrite)) {
				using (BinaryWriter binaryWriter = new BinaryWriter(fileStream)) {
					for(int y=0; y<bitmap.Height; y++) {
						for(int x=0; x<bitmap.Width; x++) {
							if(bitmap.GetPixel(x, y).R < 100) {
								bit = 1;
							} else {
								bit = 0;
							}
							binaryWriter.Write(bit);
						}
					}
					fileStream.Flush();
				}
			}
		}

		private void OnRedrawBtnClick(object sender, EventArgs e) {
			graphics.Clear(Color.White);
			ImageView.Invalidate();
		}

		private void OnExitBtnClick(object sender, EventArgs e) {
			Application.Exit();
		}

		private void OnTopBarMouseDown(object sender, MouseEventArgs e) {
			isDragging = true;
			dragStartPoint = e.Location;
		}
		private void OnTopBarMouseMove(object sender, MouseEventArgs e) {
			if (isDragging) {
				this.Location = new Point(Cursor.Position.X - dragStartPoint.X, Cursor.Position.Y - dragStartPoint.Y);
			}
		}
		private void OnTopBarMouseUp(object sender, MouseEventArgs e) {
			isDragging = false;
		}

		private void OnImageMouseDown(object sender, MouseEventArgs e) {
			isDrawing = true;
			drawStartPoint = e.Location;
		}
		private void OnImageMouseMove(object sender, MouseEventArgs e) {
			const int Scale = 4;
			if (isDrawing) {
				Point point = new Point(e.X / Scale, e.Y / Scale);
				point.X = PMath.Clamp(point.X, 0, bitmap.Width - 1);
				point.Y = PMath.Clamp(point.Y, 0, bitmap.Height - 1);

				Color color;
				if (e.Button == MouseButtons.Left) {
					color = Color.Black;
				} else {
					color = Color.White;
				}
				bitmap.SetPixel(point.X, point.Y, color);


				ImageView.Invalidate();
			}
		}
		private void OnImageMouseUp(object sender, MouseEventArgs e) {
			isDrawing = false;
		}



	}
	public static class PMath {
		public static int Clamp(int value, int min, int max) {
			if (value < min) {
				return min;
			} else if (value > max) {
				return max;
			} else {
				return value;
			}
		}
	}
}
