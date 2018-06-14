using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string heightNumber;
        string weightNumber;
        int choseNumber;
        public MainWindow()
        {
            InitializeComponent();
        }
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //關閉程式
            this.Close();
        }

        private void Title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //移動視窗
            this.DragMove();
        }

        private void FormalBtn_Click(object sender, RoutedEventArgs e)
        {

            choseNumber = 1;
        }

        private void AsianBtn_Click(object sender, RoutedEventArgs e)
        {
            choseNumber = 2;
        }

        private void weightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                //轉化搖桿數值
                weightNumber = weightSlider.Value.ToString();
                double weightWeight = (weightSlider.Value - weightSlider.Minimum) / (weightSlider.Maximum - weightSlider.Minimum);
                double range = weightSlider.ActualWidth - weightSlider.ActualWidth;
                double weightN = Math.Round(double.Parse(weightNumber));

                //計算BMI值
                double bmi = weightSlider.Value / Math.Pow(heigtSlider.Value / 100, 2);

                //拆分小數與整數
                string[] parts = Math.Round(bmi, 1).ToString().Split('.');

                //顯示數值
                weigtBlock.Text = weightN.ToString();
                numberOne.Text = parts[0];
                if (parts.Length > 1)
                {
                    numberTwo.Text = "." + parts[1];
                }

                //顯示體重的範圍
                if (choseNumber == 1)
                {
                    if (bmi <= 24.9 && bmi >= 18.5)
                    {
                        bmiText.Text = "您的體形為：正常";
                    }
                    else if (bmi < 18.5)
                    {
                        bmiText.Text = "您的體形為：過瘦";
                    }
                    else if (bmi <= 30 && bmi > 24.9)
                    {
                        bmiText.Text = "您的體形為：過重";
                    }
                    else
                    {
                        bmiText.Text = "您的體形為：肥胖";
                    }
                }
                else if (choseNumber == 2)
                {
                    if (bmi <= 22.9 && bmi >= 18.5)
                    {
                        bmiText.Text = "您的體形為：正常";
                    }
                    else if (bmi < 18.5)
                    {
                        bmiText.Text = "您的體形為：過瘦";
                    }
                    else if (bmi <= 23 && bmi > 22.9)
                    {
                        bmiText.Text = "您的體形為：過重";
                    }
                    else
                    {
                        bmiText.Text = "您的體形為：肥胖";
                    }
                }
            }


        }

        private void heigtSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                //轉化搖桿數值
                heightNumber = heigtSlider.Value.ToString();

                double heightWeight = (heigtSlider.Value - heigtSlider.Minimum) / (heigtSlider.Maximum - heigtSlider.Minimum);
                double range = heigtSlider.ActualWidth - heigtSlider.ActualWidth;
                double heightN = Math.Round(double.Parse(heightNumber));

                //計算BMI值
                double bmi = weightSlider.Value / Math.Pow(heigtSlider.Value / 100, 2);

                //拆分小數與整數
                string[] parts = Math.Round(bmi, 1).ToString().Split('.');

                //顯示數值
                heightBlock.Text = heightN.ToString();
                numberOne.Text = parts[0];
                if (parts.Length > 1)
                {
                    numberTwo.Text = "." + parts[1];
                }

                //顯示體重範圍
                if (choseNumber == 1)
                {
                    if (bmi <= 24.9 && bmi >= 18.5)
                    {
                        bmiText.Text = "您的體形為：正常";
                    }
                    else if (bmi < 18.5)
                    {
                        bmiText.Text = "您的體形為：過瘦";
                    }
                    else if (bmi <= 30 && bmi > 24.9)
                    {
                        bmiText.Text = "您的體形為：過重";
                    }
                    else
                    {
                        bmiText.Text = "您的體形為：肥胖";
                    }
                }
                else if (choseNumber == 2)
                {
                    if (bmi <= 22.9 && bmi >= 18.5)
                    {
                        bmiText.Text = "您的體形為：正常";
                    }
                    else if (bmi < 18.5)
                    {
                        bmiText.Text = "您的體形為：過瘦";
                    }
                    else if (bmi <= 23 && bmi > 22.9)
                    {
                        bmiText.Text = "您的體形為：過重";
                    }
                    else
                    {
                        bmiText.Text = "您的體形為：肥胖";
                    }
                }


            }
        }

        private void closeBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //建立關閉程式代碼
            this.Close();
        }

        private void returnBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //重置按鈕
            heigtSlider.Value = heigtSlider.Minimum;
            weightSlider.Value = weightSlider.Minimum;
        }
    }
}
   
