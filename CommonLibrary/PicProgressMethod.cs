using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    class PicProgressMethod
    {
        /// <summary>
        /// 指定比例缩放图像
        /// </summary>
        /// <param name="srcPic"></param>
        /// <param name="dstPic"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public static void PicProgress(Bitmap srcPic,out Bitmap dstPic,float ratio)
        {
            //异常直接返回
            if ((srcPic == null) || (ratio <= 0))
            {
                dstPic = null;
                return;
            }
            //处理图像
            int newWidth = (int)(srcPic.Width * ratio);
            int newHeight = (int)(srcPic.Height * ratio);
            Image thumbnailImage = srcPic.GetThumbnailImage(newWidth, newHeight, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            dstPic = new System.Drawing.Bitmap(thumbnailImage);
            //释放资源
            srcPic.Dispose();
            srcPic = null;
        }
        private static bool ThumbnailCallback()
        {
            return false;
        }
        /// <summary>
        /// 获取图片编码类型
        /// </summary>
        /// <param name="mimeType"></param>
        /// <returns></returns>
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

    }
}
