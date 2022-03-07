using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class WMD
{
	public WMD()
	{
    }
    #region
    public Bitmap Rotate(Bitmap b, Single angle)
    {
        angle = angle % 360;

        //弧度转换
        double radian = angle * Math.PI / 180.0;
        double cos = Math.Cos(radian);
        double sin = Math.Sin(radian);

        //原图的宽和高
        int w = b.Width;
        int h = b.Height;

        //目标位图
        Bitmap dsImage = new Bitmap(w, h);
        Graphics g = Graphics.FromImage(dsImage);
        Pen pn = new Pen(Color.Black, 5);
        Brush br = new SolidBrush(Color.LightGray);
        Brush br1 = new SolidBrush(Color.Black);
        g.InterpolationMode = InterpolationMode.Bilinear;
        g.SmoothingMode = SmoothingMode.HighQuality;
        g.DrawEllipse(pn, 2, 2, 115, 115);
        g.FillEllipse(br, 4, 4, 111, 111);
        Point p = new Point(Convert.ToInt32(55 + cos * 40), Convert.ToInt32(55 - sin * 40));
        g.FillEllipse(br1, p.X - 3, p.Y - 3, 14, 14);

        g.Save();
        g.Dispose();
        return dsImage;
    }
    #endregion 图片旋转函数
}
