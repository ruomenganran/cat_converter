using DataConvert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CatConverter
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public string TextChangedHandle = "";
        private Textshow textshow = new Textshow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TB_Hex_TextChanged(object sender, TextChangedEventArgs e)
        {
            if((TextChangedHandle=="ASCII")||(TextChangedHandle=="DECIMAL") ||(TextChangedHandle=="BINARY") || (TextChangedHandle == "Format"))
            {
                return;
            }
            TextChangedHandle = "HEX";
            string[] RealHex= textshow.GetRealString("HEX", TB_Hex.Text);
            int StrNum = RealHex.Length;
            string[] temp = new string[StrNum];
            TB_ASCII.Text = "";
            TB_Dec.Text = "";
            TB_Bin.Text = "";
            
            for (int i=0;i<StrNum;i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToASCII");
                temp[i] = textshow.Show;
            }
            TB_ASCII.Text = System.String.Join("\r\n", temp);

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToDecimal");
                temp[i] = textshow.Show;
            }
            TB_Dec.Text = System.String.Join("\r\n", temp);

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToBinary");
                temp[i] = textshow.Show;
            }
            TB_Bin.Text = System.String.Join("\r\n", temp);
            TextChangedHandle = "";
        }

        private void TB_Hex_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex re = new Regex(@"([^A-Fa-f0-9]|\s+?)+");
            //e.Handled = re.IsMatch(e.Text);
        }
        
        private void TB_ASCII_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex re = new Regex(@"([^A-Fa-f0-9]|\s+?)+");
            //e.Handled = re.IsMatch(e.Text);
        }

        private void TB_Dec_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex re = new Regex(@"([^A-Fa-f0-9]|\s+?)+");
            //e.Handled = re.IsMatch(e.Text);
        }

        private void TB_Bin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex re = new Regex(@"([^A-Fa-f0-9]|\s+?)+");
            //e.Handled = re.IsMatch(e.Text);
        }

        private void Button_Click_Format(object sender, RoutedEventArgs e)
        {
            TextChangedHandle = "Format";
            string[] str = textshow.GetRealString("HEX", TB_Hex.Text);
            int StrNum = str.Length;
            string[] temp = new string[StrNum];
            for (int i = 0; i < StrNum; i++)
            {
                temp[i]=textshow.DataFormat("HEX",str[i]);
            }
            TB_Hex.Text = System.String.Join("\r\n", temp);

            //十进制不能去掉空格，会造成识别有误
            //str = textshow.GetRealString("DECIMAL", TB_Dec.Text);
            //StrNum = str.Length;
            //temp = new string[StrNum];
            //for (int i = 0; i < StrNum; i++)
            //{
            //    temp[i] = textshow.DataFormat("DECIMAL", str[i]);
            //}
            //TB_Dec.Text = System.String.Join("\r\n", temp);

            str = textshow.GetRealString("BINARY", TB_Bin.Text);
            StrNum = str.Length;
            temp = new string[StrNum];
            for (int i = 0; i < StrNum; i++)
            {
                temp[i] = textshow.DataFormat("BINARY", str[i]);
            }
            TB_Bin.Text = System.String.Join("\r\n", temp);

            TextChangedHandle = "";

            //TB_Hex.Text=textshow.DataFormat("HEX", textshow.GetRealString("HEX", TB_Hex.Text));
            //TB_Dec.Text=textshow.DataFormat("DECIMAL", textshow.GetRealString("DECIMAL", TB_Dec.Text));
            //TB_Bin.Text=textshow.DataFormat("BINARY", textshow.GetRealString("BINARY", TB_Bin.Text));
        }

        private void Button_Click_UnFormat(object sender, RoutedEventArgs e)
        {
            TextChangedHandle = "Format";
            string[] str = textshow.GetRealString("HEX", TB_Hex.Text);
            int StrNum = str.Length;
            TB_Hex.Text = System.String.Join("\r\n",str);

            //str = textshow.GetRealString("DECIMAL", TB_Dec.Text);
            //StrNum = str.Length;
            //TB_Dec.Text = System.String.Join("\r\n", str);

            str = textshow.GetRealString("BINARY", TB_Bin.Text);
            StrNum = str.Length;
            TB_Bin.Text = System.String.Join("\r\n", str);
            //TB_Hex.Text = textshow.GetRealString("HEX", TB_Hex.Text);
            //TB_Dec.Text = textshow.GetRealString("DECIMAL", TB_Dec.Text);
            //TB_Bin.Text = textshow.GetRealString("BINARY", TB_Bin.Text);
            TextChangedHandle = "";
        }

        private void TB_Hex_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TB_ASCII_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((TextChangedHandle == "HEX") || (TextChangedHandle == "DECIMAL") || (TextChangedHandle == "BINARY") || (TextChangedHandle == "Format"))
            {
                return;
            }
            TextChangedHandle = "ASCII";
            //先将ascii转为16进制，然后16进制转出各个文本框
            string[] RealASCII = textshow.GetRealString("ASCII", TB_ASCII.Text);
            int AscNum = RealASCII.Length;
            string[] RealHex = new string[AscNum];
            for(int i=0;i<AscNum;i++)
            {
                textshow.show = RealASCII[i];
                textshow.Con("ASCIIToHex");
                RealHex[i] = textshow.Show;
            }

            int StrNum = RealHex.Length;
            string[] temp = new string[StrNum];
            TB_Hex.Text = System.String.Join("\r\n", RealHex);
            TB_Dec.Text = "";
            TB_Bin.Text = "";

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToDecimal");
                temp[i] = textshow.Show;
            }
            TB_Dec.Text = System.String.Join("\r\n", temp);

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToBinary");
                temp[i] = textshow.Show;
            }
            TB_Bin.Text = System.String.Join("\r\n", temp);
            TextChangedHandle = "";
        }

        private void TB_Dec_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((TextChangedHandle == "HEX") || (TextChangedHandle == "ASCII") || (TextChangedHandle == "BINARY") || (TextChangedHandle == "Format"))
            {
                return;
            }
            TextChangedHandle = "DECIMAL";
            //先将10进制转为16进制，然后16进制转出各个文本框
            string[] RealDec= textshow.GetRealString("DECIMAL", TB_Dec.Text);
            int AscNum = RealDec.Length;
            string[] RealHex = new string[AscNum];
            for (int i = 0; i < AscNum; i++)
            {
                textshow.show = RealDec[i];
                textshow.Con("DecimalToHex");
                RealHex[i] = textshow.Show;
            }

            int StrNum = RealHex.Length;
            string[] temp = new string[StrNum];
            TB_Hex.Text = System.String.Join("\r\n", RealHex);
            TB_ASCII.Text = "";
            TB_Bin.Text = "";

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToASCII");
                temp[i] = textshow.Show;
            }
            TB_ASCII.Text = System.String.Join("\r\n", temp);

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToBinary");
                temp[i] = textshow.Show;
            }
            TB_Bin.Text = System.String.Join("\r\n", temp);
            TextChangedHandle = "";
        }

        private void TB_Bin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((TextChangedHandle == "HEX") || (TextChangedHandle == "ASCII") || (TextChangedHandle == "DECIMAL") || (TextChangedHandle == "Format"))
            {
                return;
            }
            TextChangedHandle = "BINARY";
            //先将10进制转为16进制，然后16进制转出各个文本框
            string[] RealBin = textshow.GetRealString("BINARY", TB_Bin.Text);
            int BinNum = RealBin.Length;
            string[] RealHex = new string[BinNum];
            for (int i = 0; i < BinNum; i++)
            {
                textshow.show = RealBin[i];
                textshow.Con("BinaryToHex");
                RealHex[i] = textshow.Show;
            }

            int StrNum = RealHex.Length;
            string[] temp = new string[StrNum];
            TB_Hex.Text = System.String.Join("\r\n", RealHex);
            TB_ASCII.Text = "";
            TB_Dec.Text = "";

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToASCII");
                temp[i] = textshow.Show;
            }
            TB_ASCII.Text = System.String.Join("\r\n", temp);

            for (int i = 0; i < StrNum; i++)
            {
                textshow.show = RealHex[i];
                textshow.Con("HexToDecimal");
                temp[i] = textshow.Show;
            }
            TB_Dec.Text = System.String.Join("\r\n", temp);
            TextChangedHandle = "";
        }
    }
}

namespace DataConvert
{
    class Textshow : INotifyPropertyChanged //绑定对象  
    {
        public string format = "";//转换格式
        public string show="";//显示
        public event PropertyChangedEventHandler PropertyChanged;
        public string Show
        {
            get
            {
                return show;
            }
            set
            {
                show = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Show"));
            }
        }
        public void Con(string output)
        {
            if(output=="HexToASCII")
            {
                show = HexStringToASCII(show);
            }
            else if(output=="HexToDecimal")
            {
                show = HexStringToDecimal(show);
            }
            else if(output=="HexToBinary")
            {
                show = HexStringToBinary(show);
            }
            else if(output=="ASCIIToHex")
            {
                show = ASCIIStringToHex(show);
            }
            else if(output== "DecimalToHex")
            {
                show = DecimalStringToHex(show);
            }
            else if(output=="BinaryToHex")
            {
                show = BinaryStringToHex(show);
            }
        }
        public static string HexStringToASCII(string hexstring)
        {
            if (hexstring.Length%2!=0)
            {
                hexstring=hexstring.Insert(hexstring.Length - 1, "0");
            }
            byte[] buff = new byte[hexstring.Length / 2];
            int index = 0;
            
            for(int i=0;i<hexstring.Length;i+=2)
            {
                buff[index] = Convert.ToByte(hexstring.Substring(i, 2), 16);
                ++index;
            }
            string result = Encoding.Default.GetString(buff);
            return result;
        }
        public static string HexStringToDecimal(string hexstring)
        {
            if (hexstring.Length % 2 != 0)
            {
                hexstring = hexstring.Insert(hexstring.Length - 1, "0");
            }
            string[] buff = new string[hexstring.Length/2];
            int index = 0;
            ushort temp = 0;

            for (int i = 0; i < hexstring.Length; i += 2)
            {
                temp = Convert.ToUInt16(hexstring.Substring(i, 2), 16);
                buff[index] = Convert.ToString(temp, 10);
                buff[index] = buff[index].PadLeft(2, '0');
                ++index;
            }
            string result_ = System.String.Join(" ",buff);
            return result_;
        }
        public static string HexStringToBinary(string hexstring)
        {
            if (hexstring.Length % 2 != 0)
            {
                hexstring = hexstring.Insert(hexstring.Length - 1, "0");
            }
            string[] buff = new string[hexstring.Length/2];
            int index = 0;
            ushort temp = 0;

            for (int i = 0; i < hexstring.Length; i += 2)
            {
                temp = Convert.ToUInt16(hexstring.Substring(i, 2), 16);
                buff[index] = Convert.ToString(temp, 2);
                buff[index] = buff[index].PadLeft(8, '0');
                ++index;
            }
            
            string result_ = System.String.Join("", buff);
            return result_;
        }
        public static string ASCIIStringToHex(string ASCIIstring)
        {
            string result = "";
            char[] values = ASCIIstring.ToCharArray();
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                string temp= Convert.ToString(letter, 16);
                result += temp.PadLeft(2, '0');
            }

            return result;
        }
        public static string DecimalStringToHex(string Decimalstring)
        {
            

            string result = "";
            string[] temp = Decimalstring.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            foreach(string unit in temp)
            {
                ushort temp_int = Convert.ToUInt16(unit, 10);
                string temp_ = Convert.ToString(temp_int, 16);
                result += temp_.PadLeft(2, '0');
            }

            //ushort[] temp_int = Convert.ToUInt16(temp,10);

            return result;
        }
        public static string BinaryStringToHex(string Binarystring)
        {
            string result = "";
            //识别使用空格分隔的字符
            string[] temp = Binarystring.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //为不整齐的字符串补齐
            for(int i=0;i<temp.Length;i++)
            {
                if(temp[i].Length%8!=0)
                {
                    string tem_str= temp[i].Substring(temp[i].Length - temp[i].Length % 8).PadLeft(8, '0');
                    temp[i] = temp[i].Remove(temp[i].Length - temp[i].Length % 8);
                    temp[i] = temp[i] + tem_str ;
                }
            }
            
            foreach (string unit in temp)
            {
                int index = 0;
                for (int i=0;i<unit.Length/8;i++)
                {
                    ushort temp_int = Convert.ToUInt16(unit.Substring(index, 8), 2);
                    
                    string temp_= Convert.ToString(temp_int, 16);
                    result += temp_.PadLeft(2, '0');
                    index += 8;
                }
            }

            //ushort[] temp_int = Convert.ToUInt16(temp,10);

            return result;
        }
        public string DataFormat(string format,string str)
        {
            int len = str.Length;
            switch(format)
            {
                case "HEX"://16进制两个字符一个空格
                    if(str.Length==0)
                    {
                        return str;
                    }
                    else if (len % 2 != 0)
                    {
                        str = str.Insert(len - 1, "0");
                    }
                    for (int i=0;i<(len / 2+ len % 2-1);i++)
                    {
                        str = str.Insert((i+1)*2+i, " ");
                    }
                    break;
                case "DECIMAL":
                    if (len == 0)
                    {
                        return str;
                    }
                    //else if (len % 2 != 0)
                    //{
                    //    str = str.Insert(len - 1, "0");
                    //}
                    //for (int i = 0; i < (len / 2 + len % 2 - 1); i++)
                    //{
                    //    str = str.Insert((i + 1) * 2 + i, " ");
                    //}
                    break;
                case "BINARY"://2进制8个字符一个空格
                    if (len == 0)
                    {
                        return str;
                    }
                    else if (len % 8 != 0)
                    {
                        str = str.Substring(len - len % 8).PadLeft(8,'0');
                    }
                    for (int i = 0; i < (len / 8 + len % 8 - 1); i++)
                    {
                        str = str.Insert((i + 1) * 8 + i, " ");
                    }
                    break;
            }
            return str;
        }
        public string[] GetRealString(string format,string str)
        {
            string[] result;//每个换行新开出来一个str，
            Regex re;
            switch (format)
            {
                case "HEX":
                    re = new Regex(@"([^A-Fa-f0-9\n]+?)+");
                    str = re.Replace(str,"");
                    break;
                case "ASCII":
                    re = new Regex(@"([\r]+?)+");
                    str = re.Replace(str, "");
                    break;
                case "DECIMAL":
                    re = new Regex(@"([^0-9\n\s]|\r|\f|\t|\v+?)+");
                    str = re.Replace(str, "");
                    break;
                case "BINARY":
                    re = new Regex(@"([^01\n\s]|\r|\f|\t|\v+?)+");
                    str = re.Replace(str, "");
                    break;
            }
            result = str.Split('\n');
            //十进制单独处理
            //先对字符串处理，如果用户字符没有空格分开，则分开后在转换
            if(format=="DECIMAL")
            {
                for(int i=0;i<result.Length;i++)
                {
                    string[] unit_str = result[i].Split(' ');
                    int Temp = unit_str.Length;
                    for(int j=0;j<Temp;j++)
                    {
                        if(unit_str[j].Length>=3)
                        {
                            UInt32 temp = Convert.ToUInt32(unit_str[j]);
                            if((temp>255)||(unit_str[j].Length>=4))//要分割字符串
                            {
                                int len = unit_str[j].Length;
                                for (int k = 0; k < (len / 2 + len % 2 - 1); k++)
                                {
                                    unit_str[j] = unit_str[j].Insert((k + 1) * 2 + k, " ");
                                }
                            }
                        }
                    }
                    result[i] = System.String.Join(" ", unit_str);
                }
            }
            

            return result;
        }
        
    }
    
    

}