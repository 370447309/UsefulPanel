using Negative.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negative.Common.Plugin
{
    /// <summary>
    /// 插件中的小组件
    /// </summary>
    public class ComponentObject : BaseModel
    {
        private string _title = string.Empty;
        private object _icon;
        private string _description = string.Empty;
        private object _componentView;
        
        /// <summary>
        /// 获取或设置小组件的title
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 获取或设置小组件的描述信息
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 获取或设置小组件的图标
        /// </summary>
        public object Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 获取或设置小组件视图
        /// </summary>
        public object ComponentView
        {
            get => _componentView;
            set
            {
                _componentView = value;
                OnPropertyChanged();
            }
        }
    }
}
