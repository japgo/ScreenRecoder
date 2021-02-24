using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace ScreenRecoderTest
{
	class ScreenRecoder
	{
		VideoWriter m_recoder = null;
		string m_file_name = string.Empty;
		Mat frame = new Mat();

		BackgroundWorker bg_worker = null;
		bool m_recode_enable = false;

		Rectangle rect = Screen.PrimaryScreen.Bounds;
		PixelFormat pixelFormat;

		public ScreenRecoder()
		{
			bg_worker = new BackgroundWorker();
			bg_worker.DoWork += new DoWorkEventHandler( worker_DoWork );

			int bitsPerPixel = Screen.PrimaryScreen.BitsPerPixel;
			pixelFormat = PixelFormat.Format32bppArgb;
			if( bitsPerPixel <= 16 )
			{
				pixelFormat = PixelFormat.Format16bppRgb565;
			}
			if( bitsPerPixel == 24 )
			{
				pixelFormat = PixelFormat.Format24bppRgb;
			}
			
		}

		void worker_DoWork( object sender, DoWorkEventArgs e )
		{
			Bitmap bmp = new Bitmap( rect.Width, rect.Height, pixelFormat );
			while( m_recode_enable )
			{

				Graphics gr = Graphics.FromImage( bmp );
				
				// 화면을 그대로 카피해서 Bitmap 메모리에 저장
				gr.CopyFromScreen( rect.Left, rect.Top, 0, 0, rect.Size, CopyPixelOperation.SourceCopy );
				bmp.Save( m_file_name + ".bmp" );

				frame = OpenCvSharp.Extensions.BitmapConverter.ToMat( bmp );
				m_recoder.Write( frame );

				Thread.Sleep( 1 );
			}
			//m_recoder.Release();
		}

		public void start_recode( string _file_name = "", int _fps = 30)
		{
			m_file_name = _file_name == "" ? m_file_name : _file_name;

			m_recoder = new VideoWriter( _file_name, FourCC.XVID, _fps, new OpenCvSharp.Size( rect.Width, rect.Height ) );
			m_recode_enable = true;
			bg_worker.RunWorkerAsync();
		}

		public void stop_recode()
		{
			m_recode_enable = false;
		}
	}
}
