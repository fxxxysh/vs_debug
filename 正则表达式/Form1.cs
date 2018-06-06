using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 正则表达式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test();
        }

        void test()
        {
            string str = "[VALUE]gyro1_offset[1233.313 ,    98.2312, 3.1243]";
            List<string> str_list = new List<string>();
            string pattern = @"(?<=\[).*?(?=\])"; //提取[]内部字符串

            foreach (Match match in Regex.Matches(str, pattern))
            {
                str_list.Add(match.Value);
            }

            if (str_list.Count != 0)
            {
                switch (str_list[0])
                {
                    case "INFO":
                        //info_label.Text = str.Split(']')[1];
                        break;

                    case "VALUE":
                        string name = null;
                        foreach (Match match in Regex.Matches(str, @"(?<=\]).*?(?=\[)"))//提取][内部字符串
                        {
                            name = match.Groups[0].Value;
                        }
                        string[] str_value = str_list[1].Replace(" ", "").Split(','); //去除空格,逗号分割

                        string str_index = null;
                        foreach (Match match in Regex.Matches(name, @"[0-9]+")) //name index
                        {
                            str_index = match.Groups[0].Value;
                        }

                        if (str_index != null)
                        {
                            int index = int.Parse(str_index);
                            //_gyro_offset_dt.Rows[index][0] = name;

                            for (int i = 0; i < 20; i++)
                            {
                                //_gyro_offset_dt.Rows[index][i + 1] = float.Parse(str_value[i]);
                            }
                        }
                        break;

                    default: break;
                }
            }
        }
    }
}
