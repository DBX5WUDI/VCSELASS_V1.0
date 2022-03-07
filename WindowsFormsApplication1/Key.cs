using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Key
    {
        public Key()
        {
        }
        public void KeyUpDown(PreviewKeyDownEventArgs e, TextBox str)
        {
            if (e.KeyCode == Keys.Up)
            {
                Int16 UpdateText;
                str.Select(str.SelectionStart, 1);
                if (str.SelectedText != "" && char.IsNumber(Convert.ToChar(str.SelectedText)))
                {
                    UpdateText = Convert.ToInt16(str.SelectedText);
                    if (UpdateText < 9)
                    {
                        UpdateText++;
                    }

                    else
                    {
                        UpdateText = 0;
                    } 
                    str.SelectedText = UpdateText.ToString();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                Int16 UpdateText;
                str.Select(str.SelectionStart, 1);
                if (char.IsNumber(Convert.ToChar(str.SelectedText)))
                {
                    UpdateText = Convert.ToInt16(str.SelectedText);
                    if (UpdateText > 0)
                    {
                        UpdateText--;
                    }
                    else
                    {
                        UpdateText = 9;
                    }
                    str.SelectedText = UpdateText.ToString();
                    if (str.SelectionStart > 1)
                    {
                        str.Select(str.SelectionStart - 2, 0);
                    }
                    else
                    {
                        str.Select(0, 0);
                    }
                }
                else
                {
                    str.Select(str.SelectionStart - 1, 0);
                }
                
            }
        }
        public void KeyConfineNum(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是小数点键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar!=(char)'.')
            {
                e.Handled = true;
            }
        }
    }
}