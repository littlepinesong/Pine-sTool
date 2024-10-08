using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Resources;
using Pine_sTool.Properties;

namespace Pine_sTool.MainControl
{
    class ImageHelper
    {
        private static global::System.Globalization.CultureInfo resourceCulture;
        private static global::System.Resources.ResourceManager resourceMan;
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pine_sTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        public static void AddImagesFromResource(ImageCollection imageCollection,string resourcePrefix = "_", int startIndex = 0, int count = 999)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            for (int i = 1; i < count; i++)
            {
                try
                {
                    string resourceName = $"{resourcePrefix}{startIndex + i}"; // 假设资源文件名的格式为 prefix1.png, prefix2.png, ...
                    object obj = ResourceManager.GetObject(resourceName, resourceCulture);
                    Bitmap bitmap = ((System.Drawing.Bitmap)(obj));
                    imageCollection.AddImage(bitmap);
                    //imageCollection.AddImage(Properties.Resources._16);
                }
                catch (Exception)
                {}
            }
        }
        //使用不成功
        //public static void AddImagesFromResource(ImageCollection imageCollection, string nameSpace= "System.Drawing", string resourcePrefix="_",string resourceSuffix="png", int startIndex=0, int count=999)
        //{
        //    Assembly assembly = Assembly.GetExecutingAssembly();
        //    for (int i = 1; i < count; i++)
        //    {
        //        string resourceName = $"{nameSpace}.{resourcePrefix}{startIndex + i}.{resourceSuffix}"; // 假设资源文件名的格式为 prefix1.png, prefix2.png, ...
        //        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //        {
        //            if (stream != null)
        //            {
        //                Bitmap bitmap = new Bitmap(stream);
        //                imageCollection.AddImage(bitmap);
        //            }
        //            else
        //            {
        //                //throw new ArgumentException($"Resource {resourceName} not found.");
        //            }
        //        }
        //    }
        //}
    }
}
