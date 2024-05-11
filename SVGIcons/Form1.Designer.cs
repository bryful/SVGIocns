namespace SVGIcons
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.iconBtnTable1 = new SVGIcon.IconBtnTable();
			this.iconBtn1 = new SVGIcon.IconBtn();
			this.iconBtnTable2 = new SVGIcon.IconBtnTable();
			this.SuspendLayout();
			// 
			// iconBtnTable1
			// 
			this.iconBtnTable1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.iconBtnTable1.Count = 7;
			this.iconBtnTable1.ForeColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ControlLightLight,
        System.Drawing.SystemColors.ControlText,
        System.Drawing.Color.DarkOrange,
        System.Drawing.SystemColors.ControlText,
        System.Drawing.SystemColors.Highlight,
        System.Drawing.SystemColors.ControlText,
        System.Drawing.Color.Yellow};
			this.iconBtnTable1.ICONSTAT = new SVGIcon.SVG_ICON[] {
        SVGIcon.SVG_ICON.add,
        SVGIcon.SVG_ICON.edit,
        SVGIcon.SVG_ICON.delete,
        SVGIcon.SVG_ICON.None,
        SVGIcon.SVG_ICON.move_down,
        SVGIcon.SVG_ICON.move_up,
        SVGIcon.SVG_ICON.add};
			this.iconBtnTable1.Location = new System.Drawing.Point(416, 252);
			this.iconBtnTable1.Name = "iconBtnTable1";
			this.iconBtnTable1.PushEnabled = new bool[] {
        false,
        true,
        true,
        false,
        true,
        true,
        true};
			this.iconBtnTable1.Size = new System.Drawing.Size(331, 37);
			this.iconBtnTable1.TabIndex = 1;
			this.iconBtnTable1.Text = "iconBtnTable1";
			// 
			// iconBtn1
			// 
			this.iconBtn1.Location = new System.Drawing.Point(294, 12);
			this.iconBtn1.Name = "iconBtn1";
			this.iconBtn1.PushEnabled = false;
			this.iconBtn1.RevColor = System.Drawing.Color.White;
			this.iconBtn1.Size = new System.Drawing.Size(234, 234);
			this.iconBtn1.SVG_ICON = SVGIcon.SVG_ICON.warning;
			this.iconBtn1.TabIndex = 0;
			this.iconBtn1.Text = "iconBtn1";
			// 
			// iconBtnTable2
			// 
			this.iconBtnTable2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.iconBtnTable2.Count = 3;
			this.iconBtnTable2.ForeColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.HighlightText,
        System.Drawing.SystemColors.HotTrack,
        System.Drawing.Color.Red};
			this.iconBtnTable2.ICONSTAT = new SVGIcon.SVG_ICON[] {
        SVGIcon.SVG_ICON.api,
        SVGIcon.SVG_ICON.file_open,
        SVGIcon.SVG_ICON.expand_less};
			this.iconBtnTable2.Location = new System.Drawing.Point(37, 252);
			this.iconBtnTable2.Name = "iconBtnTable2";
			this.iconBtnTable2.PushEnabled = new bool[] {
        false,
        true,
        true};
			this.iconBtnTable2.Size = new System.Drawing.Size(319, 103);
			this.iconBtnTable2.TabIndex = 2;
			this.iconBtnTable2.Text = "iconBtnTable2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 378);
			this.Controls.Add(this.iconBtnTable2);
			this.Controls.Add(this.iconBtnTable1);
			this.Controls.Add(this.iconBtn1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private SVGIcon.IconBtn iconBtn1;
		private SVGIcon.IconBtnTable iconBtnTable1;
		private SVGIcon.IconBtnTable iconBtnTable2;
	}
}

