﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using HeBianGu.Base.WpfBase;
using HeBianGu.Control.PropertyGrid;
using HeBianGu.General.WpfControlLib;
using HeBianGu.Service.Mvc;

namespace HeBianGu.App.Disk
{
    [ViewModel("Extend")]
    internal class ExtendViewModel : MvcViewModelBase
    {


        protected override void Init()
        {
        }

        protected override void Loaded(string args)
        {
        }

        /// <summary> 命令通用方法 </summary>
        protected override async void RelayMethod(object obj)

        {
            string command = obj?.ToString();

            //  Do：对话消息
            if (command == "Sumit")
            {

            }

            //  Do：等待消息
            else if (command == "Cancel")
            {

            }
        }

    }
}