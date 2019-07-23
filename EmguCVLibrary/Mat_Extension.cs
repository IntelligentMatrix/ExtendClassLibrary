﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

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
    }
}
