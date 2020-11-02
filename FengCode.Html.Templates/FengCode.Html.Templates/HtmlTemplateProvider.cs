using System;

namespace FengCode.Html.Templates
{
    /// <summary>
    /// HTML模板提供器
    /// </summary>
    public static class HtmlTemplateProvider
    {
        /// <summary>
        /// 服务器内部错误
        /// </summary>
        public static string Error500
        {
            get { return Properties.Resources.error_500; }
        }

        /// <summary>
        /// 服务暂时不可用
        /// </summary>
        public static string Error503
        {
            get { return Properties.Resources.error_503; }
        }

        /// <summary>
        /// 网站错误的默认模板
        /// </summary>
        public static string ErrorDefault
        {
            get { return Properties.Resources.error_default; }
        }
        /// <summary>
        /// 404模板（简约风格）
        /// </summary>
        public static string Error404
        {
            get
            {
                return Properties.Resources.error_404;
            }
        }

        /// <summary>
        /// 404模板（紫色星空动画）
        /// </summary>
        public static string Error404_Star
        {
            get { return Properties.Resources.error_404_star; }
        }
    }
}
