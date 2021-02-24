using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRecoderTest
{
	public partial class Form1 : Form
	{
		ScreenRecoder m_recoder = new ScreenRecoder();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnRecordStart_Click( object sender, EventArgs e )
		{
			m_recoder.start_recode( "./test.avi" );
		}

		private void btnRecordStop_Click( object sender, EventArgs e )
		{
			m_recoder.stop_recode();
		}
	}
}
