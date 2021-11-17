using Negative.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negative.Common.Plugin
{
    /// <summary>
    /// 插件视图
    /// </summary>
    public class ContextObject : BaseModel
    {
        private string _title = string.Empty;
        private string _description = string.Empty;
        private object _icon;
        private object _contextView;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public object Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                OnPropertyChanged();
            }
        }

        public object ContextView
        {
            get => _contextView;
            set
            {
                _contextView = value;
                OnPropertyChanged();
            }
        }
    }
}
