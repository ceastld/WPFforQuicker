using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFforQuicker.Tutorial
{
    using Quicker.Public;
    using System.Windows;
    internal class CSStepDemo
    {
        public static void Exec(IStepContext context)
        {
            string text = (string)context.GetVarValue("text");
            MessageBox.Show("动作中text变量当前值:" + text);
            context.SetVarValue("text", "hhhh");
            MessageBox.Show("设置动作中text变量等待值后:" + context.GetVarValue("text"));
        }
    }
}
