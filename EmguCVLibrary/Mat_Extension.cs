using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.CvEnum;

namespace EmguCVLibrary
{
    //基于Image的拓展类
    public static class MatExtension
    {

        /*
        * Caution!
        * The following method may leak memory and cause unexcepted errors.
        * Plase use GetArray after calling GetImage methods.
        */
        public static double[] GetDoubleArray(this Mat mat)
        {
            double[] temp = new double[mat.Height * mat.Width];
            Marshal.Copy(mat.DataPointer, temp, 0, mat.Height * mat.Width);
            return temp;
        }

        /*
        * Caution!
        * The following method may leak memory and cause unexcepted errors.
        * Plase use GetArray after calling GetImage methods.
        */
        public static int[] GetIntArray(this Mat mat)
        {
            int[] temp = new int[mat.Height * mat.Width];
            Marshal.Copy(mat.DataPointer, temp, 0, mat.Height * mat.Width);
            return temp;
        }

        /*
        * Caution!
        * The following method may leak memory and cause unexcepted errors.
        * Plase use GetArray after calling GetImage methods.
        */
        public static byte[] GetByteArray(this Mat mat)
        {
            byte[] temp = new byte[mat.Height * mat.Width];
            Marshal.Copy(mat.DataPointer, temp, 0, mat.Height * mat.Width);
            return temp;
        }

        /*
        * Caution!
        * The following method may leak memory and cause unexcepted errors.
        * Plase use GetArray after calling GetImage methods.
        */
        public static void SetDoubleArray(this Mat mat, double[] data)
        {
            Marshal.Copy(data, 0, mat.DataPointer, mat.Height * mat.Width);
        }

        /*
        * Caution!
        * The following method may leak memory and cause unexcepted errors.
        * Plase use GetArray after calling GetImage methods.
        */
        public static void SetIntArray(this Mat mat, int[] data)
        {
            Marshal.Copy(data, 0, mat.DataPointer, mat.Height * mat.Width);
        }

        /*
        * Caution!
        * The following method may leak memory and cause unexcepted errors.
        * Plase use GetArray after calling GetImage methods.
        */
        public static void SetByteArray(this Mat mat, byte[] data)
        {
            Marshal.Copy(data, 0, mat.DataPointer, mat.Height * mat.Width);
        }
        /// <summary>
        /// Convert Mat into Gray Image
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Image<Gray, Byte> GetGrayImage(this Mat mat)
        {
            Image<Gray, Byte> image = mat.ToImage<Gray, Byte>();
            return image;
        }
        /// <summary>
        /// Convert Mat into Bgr Image
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Image<Bgr, Byte> GetBgrImage(this Mat mat)
        {
            Image<Bgr, Byte> image = mat.ToImage<Bgr, Byte>();
            return image;
        }
        /// <summary>
        /// Convert Mat into Xyz Image
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Image<Xyz, Byte> GetXyzImage(this Mat mat)
        {
            Image<Xyz, Byte> image = mat.ToImage<Xyz, Byte>();
            return image;
        }
        /// <summary>
        /// Convert Mat into Bgra Image
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Image<Bgra, Byte> GetBgraImage(this Mat mat)
        {
            Image<Bgra, Byte> image = mat.ToImage<Bgra, Byte>();
            return image;
        }

        /// <summary>
        /// Convert Mat into Bitmap
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Bitmap GetBitmap(this Mat mat)
        {
            return mat.Bitmap;
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public static dynamic GetValue(this Mat mat, int row, int col)
        {
            var value = CreateElement(mat.Depth);
            Marshal.Copy(mat.DataPointer + (row * mat.Cols + col) * mat.ElementSize, value, 0, 1);
            return value[0];
        }
        /// <summary>
        /// 设置数据
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        public static void SetValue(this Mat mat, int row, int col, dynamic value)
        {
            var target = CreateElement(mat.Depth, value);
            Marshal.Copy(target, 0, mat.DataPointer + (row * mat.Cols + col) * mat.ElementSize, 1);
        }
        /// <summary>
        /// 创建元素
        /// </summary>
        /// <param name="depthType"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static dynamic CreateElement(DepthType depthType, dynamic value)
        {
            var element = CreateElement(depthType);
            element[0] = value;
            return element;
        }
        /// <summary>
        /// 创建元素
        /// </summary>
        /// <param name="depthType"></param>
        /// <returns></returns>
        private static dynamic CreateElement(DepthType depthType)
        {
            if (depthType == DepthType.Cv8S)
            {
                return new sbyte[1];
            }
            if (depthType == DepthType.Cv8U)
            {
                return new byte[1];
            }
            if (depthType == DepthType.Cv16S)
            {
                return new short[1];
            }
            if (depthType == DepthType.Cv16U)
            {
                return new ushort[1];
            }
            if (depthType == DepthType.Cv32S)
            {
                return new int[1];
            }
            if (depthType == DepthType.Cv32F)
            {
                return new float[1];
            }
            if (depthType == DepthType.Cv64F)
            {
                return new double[1];
            }
            return new float[1];
        }
    }
}
