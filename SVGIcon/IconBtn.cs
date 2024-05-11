using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Svg;
using System.Diagnostics;
using System.Xml;

namespace SVGIcon
{
    public class IconBtn : Control
    {
		// ***************************************************************
		// ***************************************************************
		private Bitmap m_bitmap = new Bitmap(24, 24);
		private SVG_ICON m_SVG_ICON = SVG_ICON.add;
		[Category("SVG")]
		public SVG_ICON SVG_ICON
		{
			get { return m_SVG_ICON; }
			set
			{
				m_SVG_ICON = value;
				ChkOffScr();
				this.Invalidate();
			}
		}
		[Category("SVG")]
		public new Color ForeColor
		{
			get { return base.ForeColor; }
			set
			{
				base.ForeColor = value;
				ChkOffScr();
				this.Invalidate();
			}
		}
		[Category("SVG")]
		public new Color BackColor
		{
			get { return base.BackColor; }
			set
			{
				base.BackColor = value;
				ChkOffScr();
				this.Invalidate();
			}
		}
		private Color m_RevColor = Color.White;
		[Category("SVG")]
		public Color RevColor
		{
			get { return m_RevColor; }
			set
			{
				m_RevColor = value;
				this.Invalidate();
			}
		}
		private bool m_PushEnabled = true;
		[Category("SVG")]
		public bool PushEnabled
		{
			get { return this.m_PushEnabled; }
			set
			{
				m_PushEnabled = value;
			}
		}
		public IconBtn()
		{
			this.Size = new Size(24, 24);

			ChkSize();
			ChkOffScr();
		}
		private void ChkSize()
		{
			if (base.Width != base.Height)
			{
				base.Width = base.Height;
			}
			if (m_bitmap.Height != base.Height)
			{
				ChkOffScr();
			}
		}
		private void ChkOffScr()
		{
			m_bitmap = new Bitmap(base.Width, base.Height);
			Graphics g = Graphics.FromImage(m_bitmap);
			g.Clear(BackColor);
			if (m_SVG_ICON != SVG_ICON.None)
			{
				var assembly = Assembly.GetExecutingAssembly();
				var resourceName = SVGFNAME(m_SVG_ICON);
				using (var stream = assembly.GetManifestResourceStream(resourceName))
				{
					if (stream != null)
					{
						var doc = SvgDocument.Open<SvgDocument>(stream, new SvgOptions());
						doc.Fill = new SvgColourServer(ForeColor);
						Bitmap bm = doc.Draw(m_bitmap.Width, m_bitmap.Height);
						g.DrawImage(bm, 0, 0);
					}
				}
			}
		}

		private string SVGFNAME(SVG_ICON idx)
		{
			return "SVGIcon.svg." + Enum.GetName(typeof(SVG_ICON), idx) + ".svg";
		}
		protected override void OnResize(EventArgs e)
		{
			ChkSize();
			ChkOffScr();
			base.OnResize(e);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			//base.OnPaint(e);
			Graphics g = e.Graphics;
			g.DrawImage(m_bitmap, 0, 0);
		}
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if ((m_SVG_ICON != SVG_ICON.None) && (m_PushEnabled == true))
			{
				Control senderControl = (Control)this;
				Rectangle screenRectangle = senderControl.RectangleToScreen(
					senderControl.ClientRectangle);
				ControlPaint.FillReversibleRectangle(screenRectangle,
					m_RevColor);
			}
			base.OnMouseDown(e);
		}
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if ((m_SVG_ICON != SVG_ICON.None)&& (m_PushEnabled == true))
			{
				Control senderControl = (Control)this;
				Rectangle screenRectangle = senderControl.RectangleToScreen(
					senderControl.ClientRectangle);
				ControlPaint.FillReversibleRectangle(screenRectangle,
					m_RevColor);
			}
			base.OnMouseUp(e);
		}
	}
	public enum SVG_ICON
	{
		None =-1,
		add,
		api,
		arrow_downward_alt,
		arrow_upward_alt,
		block,
		cancel,
		chat,
		chevron_left,
		chevron_right,
		close,
		code,
		content_copy,
		content_paste,
		cut,
		delete,
		description,
		edit,
		expand_less,
		expand_more,
		file_open,
		folder,
		folder_open,
		home,
		info,
		keyboard_control_key,
		link,
		mail,
		menu,
		move_down,
		move_up,
		save,
		search,
		send,
		settings,
		star,
		warning


	}
}
