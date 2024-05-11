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


namespace SVGIcon
{
	public class IconBtnTable :Control
	{
		public delegate void IconClickEventHandler(object sender, IconClickEventArgs e);

		//イベントデリゲートの宣言
		[Category("SVG")]
		public event IconClickEventHandler IconClick;

		protected virtual void OnIconClick(IconClickEventArgs e)
		{
			IconClick?.Invoke(this, e);
		}
		[Category("SVG")]
		public SVG_ICON[] ICONSTAT
		{
			get
			{
				List<SVG_ICON> list = new List<SVG_ICON>();
				if(this.Controls.Count > 0 ) 
				{
					for(int i=0; i<this.Controls.Count; i++)
					{
						if (this.Controls[i].GetType() == typeof(IconBtn))
						{
							IconBtn ib = (IconBtn)this.Controls[i];
							list.Add(ib.SVG_ICON);
						}
					}
				}
				return list.ToArray();
			}
			set
			{
				int cnt = value.Length;
				if (cnt > this.Controls.Count) cnt = this.Controls.Count;
				for(int i=0; i<cnt; i++)
				{
					if (this.Controls[i].GetType() == typeof(IconBtn))
					{
						IconBtn ib = (IconBtn)this.Controls[i];
						ib.SVG_ICON = value[i];
					}
				}
			}
		}
		[Category("SVG")]
		public bool[] PushEnabled
		{
			get
			{
				List<bool> list = new List<bool>();
				if (this.Controls.Count > 0)
				{
					for (int i = 0; i < this.Controls.Count; i++)
					{
						if (this.Controls[i].GetType() == typeof(IconBtn))
						{
							IconBtn ib = (IconBtn)this.Controls[i];
							list.Add(ib.PushEnabled);
						}
					}
				}
				return list.ToArray();
			}
			set
			{
				int cnt = value.Length;
				if (cnt > this.Controls.Count) cnt = this.Controls.Count;
				for (int i = 0; i < cnt; i++)
				{
					if (this.Controls[i].GetType() == typeof(IconBtn))
					{
						IconBtn ib = (IconBtn)this.Controls[i];
						ib.PushEnabled = value[i];
					}
				}
			}
		}
		[Category("SVG")]
		public Color[] ForeColors
		{
			get
			{
				List<Color> list = new List<Color>();
				if (this.Controls.Count > 0)
				{
					for (int i = 0; i < this.Controls.Count; i++)
					{
						if (this.Controls[i].GetType() == typeof(IconBtn))
						{
							IconBtn ib = (IconBtn)this.Controls[i];
							list.Add(ib.ForeColor);
						}
					}
				}
				return list.ToArray();
			}
			set
			{
				int cnt = value.Length;
				if (cnt > this.Controls.Count) cnt = this.Controls.Count;
				for (int i = 0; i < cnt; i++)
				{
					if (this.Controls[i].GetType() == typeof(IconBtn))
					{
						IconBtn ib = (IconBtn)this.Controls[i];
						ib.ForeColor = value[i];
					}
				}
			}
		}
		[Category("SVG")]
		public new Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
				for (int i = 0; i < this.Controls.Count; i++)
				{
					if (this.Controls[i].GetType() == typeof(IconBtn))
					{
						IconBtn ib = (IconBtn)this.Controls[i];
						ib.BackColor = value;
					}
				}
			}
		}
		[Category("SVG")]
		public new Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}
			set
			{
				base.ForeColor = value;
				if(this.Controls.Count > 0)
				{
					IconBtn ib = (IconBtn)this.Controls[0];
					ib.ForeColor = value;

				}
			}
		}

		[Category("SVG")]
		public int Count
		{
			get { return this.Controls.Count; }
			set
			{
				if (this.Controls.Count == value)
				{

				}
				else if (this.Controls.Count > value)
				{
					for (int i = this.Controls.Count - 1; i >= value; i--)
					{
						this.Controls.RemoveAt(i);
					}
					ChkSize();
				}
				else
				{
					int cnt2 = this.Controls.Count;

					for (int i =cnt2 ; i < value; i++)
					{
						AddBtn(SVG_ICON.add);
					}
				}

			}
		}
		public IconBtnTable()
		{
			this.Size = new Size(24 * 3, 24);
			AddBtn(SVG_ICON.add);
			AddBtn(SVG_ICON.edit);
			AddBtn(SVG_ICON.close);
		}
		public void AddBtn(SVG_ICON idx)
		{
			IconBtn b = new IconBtn();
			b.Size = new Size(Height, Height);
			b.BackColor = base.BackColor;
			b.ForeColor = base.ForeColor;
			b.SVG_ICON = idx;
			b.MouseClick += (sender, e) =>
			{
				SVG_ICON ic = ((IconBtn)sender).SVG_ICON;
				OnIconClick(new IconClickEventArgs(ic));
			};
			this.Controls.Add(b);

			ChkSize();
		}
		public void ChkSize()
		{
			if (this.Controls.Count > 0)
			{
				for (int i = 0; i < this.Controls.Count; i++)
				{
					this.Controls[i].Location = new Point(this.Height * i, 0);
					this.Controls[i].Size = new Size(this.Height, this.Height);
				}
				base.Size = new Size(this.Height * this.Controls.Count, this.Height);
			}

		}
		protected override void OnResize(EventArgs e)
		{
			ChkSize();
			base.OnResize(e);
		}
		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
		}

	}
	public class IconClickEventArgs : EventArgs
	{
		public SVG_ICON icon;
		public IconClickEventArgs(SVG_ICON icon)
		{
			this.icon = icon;
		}
	}
}
