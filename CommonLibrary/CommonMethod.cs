using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    /// <summary>
    /// PointFConverter 的摘要说明。
    /// </summary> 
    public class PointFConverter : TypeConverter
    {
        // Methods
        public PointFConverter()
        {
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return ((sourceType == typeof(string)) || base.CanConvertFrom(context, sourceType));
        }
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return ((destinationType == typeof(InstanceDescriptor)) || base.CanConvertTo(context, destinationType));
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (!(value is string))
            {
                return base.ConvertFrom(context, culture, value);
            }
            string text = ((string)value).Trim();
            if (text.Length == 0)
            {
                return null;
            }
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }
            char ch = culture.TextInfo.ListSeparator[0];
            string[] textArray = text.Split(new char[] { ch });
            float[] numArray = new float[textArray.Length];
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(float));
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = (float)converter.ConvertFromString(context, culture, textArray[i]);
            }
            if (numArray.Length != 2)
            {
                throw new ArgumentException("格式不正确！");
            }
            return new PointF(numArray[0], numArray[1]);

        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
            {
                throw new ArgumentNullException("destinationType");
            }
            if ((destinationType == typeof(string)) && (value is PointF))
            {
                PointF pointf = (PointF)value;
                if (culture == null)
                {
                    culture = CultureInfo.CurrentCulture;
                }
                string separator = culture.TextInfo.ListSeparator + " ";
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(float));
                string[] textArray = new string[2];
                int num = 0;
                textArray[num++] = converter.ConvertToString(context, culture, pointf.X);
                textArray[num++] = converter.ConvertToString(context, culture, pointf.Y);
                return string.Join(separator, textArray);
            }
            if ((destinationType == typeof(InstanceDescriptor)) && (value is SizeF))
            {
                PointF pointf2 = (PointF)value;
                ConstructorInfo member = typeof(PointF).GetConstructor(new Type[] { typeof(float), typeof(float) });
                if (member != null)
                {
                    return new InstanceDescriptor(member, new object[] { pointf2.X, pointf2.Y });
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);

        }
        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            return new PointF((float)propertyValues["X"], (float)propertyValues["Y"]);
        }
        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(PointF), attributes).Sort(new string[] { "X", "Y" });
        }
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }

    /// <summary>
    /// 用于Combox显示绑定的枚举对象
    /// </summary>
    public class BindComboxEnumType<T>
    {
        /// <summary>
        /// 类型的名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public T Type { get; set; }

        private static readonly List<BindComboxEnumType<T>> bindTyps;

        static BindComboxEnumType()
        {
            bindTyps = new List<BindComboxEnumType<T>>();

            foreach (var name in Enum.GetNames(typeof(T)))
            {
                bindTyps.Add(new BindComboxEnumType<T>()
                {
                    Name = name,
                    Type = (T)Enum.Parse(typeof(T), name)
                });
            }
        }

        /// <summary>
        /// 绑定的类型数据
        /// </summary>
        public static List<BindComboxEnumType<T>> BindTyps
        {
            get { return bindTyps; }
        }
    }
    
    /// <summary>
    /// AutoMapper 帮助类
    /// </summary>
    public static class AutoMapHelper
    {

        private static bool ConfigExist(Type srcType, Type destType)
        {
            return Mapper.Configuration.FindMapper(new TypePair(srcType, destType)) == null;
        }

        private static bool ConfigExist<TSrc, TDest>()
        {
            return Mapper.Configuration.FindMapper(new TypePair(typeof(TSrc), typeof(TDest))) == null;
        }

        public static T MapTo<T>(this object source)
        {
            if (source == null)
            {
                return default(T);
            }

            if (!ConfigExist(source.GetType(), typeof(T)))
            {
                Mapper.Initialize(cfg => cfg.CreateMap(source.GetType(), typeof(T)));
            }

            return Mapper.Map<T>(source);
        }

        public static IList<T> MapTo<T>(this IEnumerable source)
        {
            foreach (var first in source)
            {
                if (!ConfigExist(first.GetType(), typeof(T)))
                {
                    Mapper.Initialize(cfg => cfg.CreateMap(first.GetType(), typeof(T)));
                }

                break;
            }

            return Mapper.Map<IList<T>>(source);
        }

        public static IList<TDest> MapTo<TSource, TDest>(this IEnumerable<TSource> source)
        {
            if (!ConfigExist<TSource, TDest>())
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TSource, TDest>());
            }

            return Mapper.Map<IList<TDest>>(source);
        }

        public static TDest MapTo<TSource, TDest>(this TSource source, TDest dest)
        where TSource : class
        where TDest : class
        {
            if (source == null)
            {
                return dest;
            }

            if (!ConfigExist<TSource, TDest>())
            {
                Mapper.Initialize(cfg => cfg.CreateMap<TSource, TDest>());
            }
            return Mapper.Map<TDest>(source);
        }
    }
}
