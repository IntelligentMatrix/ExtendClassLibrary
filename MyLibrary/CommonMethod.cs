using AutoMapper;
using AutoMapper.Configuration;
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

namespace MyLibrary 
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
    /// PointFConverter 的摘要说明。
    /// </summary> 
    public class SizeConverter : TypeConverter
    {
        // Methods
        public SizeConverter()
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
            int[] numArray = new int[textArray.Length];
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = (int)converter.ConvertFromString(context, culture, textArray[i]);
            }
            if (numArray.Length != 2)
            {
                throw new ArgumentException("格式不正确！");
            }
            return new Size(numArray[0], numArray[1]);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
            {
                throw new ArgumentNullException("destinationType");
            }
            if ((destinationType == typeof(string)) && (value is PointF))
            {
                Size size = (Size)value;
                if (culture == null)
                {
                    culture = CultureInfo.CurrentCulture;
                }
                string separator = culture.TextInfo.ListSeparator + " ";
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
                string[] textArray = new string[2];
                int num = 0;
                textArray[num++] = converter.ConvertToString(context, culture, size.Width);
                textArray[num++] = converter.ConvertToString(context, culture, size.Height);
                return string.Join(separator, textArray);
            }
            if ((destinationType == typeof(InstanceDescriptor)) && (value is Size))
            {
                Size size2 = (Size)value;
                ConstructorInfo member = typeof(PointF).GetConstructor(new Type[] { typeof(int), typeof(int) });
                if (member != null)
                {
                    return new InstanceDescriptor(member, new object[] { size2.Width, size2.Height });
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);

        }
        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            return new Size((int)propertyValues["Width"], (int)propertyValues["Height"]);
        }
        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(Size), attributes).Sort(new string[] { "Width", "Height" });
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
        /// <summary>
        /// 判断静态Mapper是都存在映射
        /// </summary>
        /// <param name="srcType"></param>
        /// <param name="destType"></param>
        /// <returns></returns>
        private static bool ConfigExist(Type srcType, Type destType)
        {
            return Mapper.Configuration.FindMapper(new TypePair(srcType, destType)) != null;
        }
        /// <summary>
        /// 判断静态Mapper是都存在映射
        /// </summary>
        /// <typeparam name="TSrc"></typeparam>
        /// <typeparam name="TDest"></typeparam>
        /// <returns></returns>
        private static bool ConfigExist<TSrc, TDest>()
        {
            return Mapper.Configuration.FindMapper(new TypePair(typeof(TSrc), typeof(TDest))) != null;
        }
        /// <summary>
        /// 映射
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T MapTo<T>(this object source)
        {
            if (source == null)
                return default(T);

            var cfg = new MapperConfigurationExpression();

            //配置表达式

            //cfg.RecognizeDestinationPrefixes("Set");        //识别目标地点前缀，还有其他识别配置

            cfg.CreateMap(source.GetType(), typeof(T));

            cfg.CreateMap(typeof(T), source.GetType());

            var config = new MapperConfiguration(cfg);

            var mapper = config.CreateMapper();             //生成一个map

            return mapper.Map<T>(source);
        }
        /// <summary>
        /// List映射
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>

        public static IList<T> MapTo<T>(this IEnumerable source)
        {
            var cfg = new MapperConfigurationExpression();
            foreach (var first in source)
            {
                //cfg.RecognizeDestinationPrefixes("Set");   //识别目标地点前缀，还有其他识别配置

                cfg.CreateMap(first.GetType(), typeof(T));

                cfg.CreateMap(typeof(T), first.GetType());

                break;
            }
            var config = new MapperConfiguration(cfg);       //生成配置文件
            var mapper = config.CreateMapper();             //生成一个map
            return mapper.Map<IList<T>>(source);
        }
        /// <summary>
        /// List映射
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDest"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IList<TDest> MapTo<TSource, TDest>(this IEnumerable<TSource> source)
        {
            var cfg = new MapperConfigurationExpression();

            //配置表达式

            //cfg.RecognizeDestinationPrefixes("Set");        //识别目标地点前缀，还有其他识别配置

            cfg.CreateMap<TSource, TDest>();         //以上都是配置表达式

            cfg.CreateMap<TDest, TSource>();         //以上都是配置表达式

            var config = new MapperConfiguration(cfg);

            var mapper = config.CreateMapper();             //生成一个map

            return mapper.Map<IList<TDest>>(source);

           
        }
        /// <summary>
        /// 映射形式1
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TDestination MapTo<TSource, TDestination>(this TSource source) where TDestination : class where TSource : class
        {
            if (source == null)
                return default(TDestination);

            var cfg = new MapperConfigurationExpression();

            //配置表达式

            //cfg.RecognizeDestinationPrefixes("Set");        //识别目标地点前缀，还有其他识别配置

            cfg.CreateMap<TSource, TDestination>();         //以上都是配置表达式

            cfg.CreateMap<TDestination, TSource>();         //以上都是配置表达式

            var config = new MapperConfiguration(cfg);

            var mapper = config.CreateMapper();             //生成一个map

            return mapper.Map<TDestination>(source);
        }
        /// <summary>
        /// 映射形式2
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDest"></typeparam>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        public static TDest MapTo<TSource, TDest>(this TSource source, TDest dest)
        where TSource : class
        where TDest : class
        {
            if (source == null)
            {
                return dest;
            }

            var cfg = new MapperConfigurationExpression();

            //配置表达式

            //cfg.RecognizeDestinationPrefixes("Set");        //识别目标地点前缀，还有其他识别配置

            cfg.CreateMap<TSource, TDest>();         //以上都是配置表达式

            cfg.CreateMap<TDest, TSource>();         //以上都是配置表达式

            var config = new MapperConfiguration(cfg);

            var mapper = config.CreateMapper();             //生成一个map

            return mapper.Map<TDest>(source);
        }
    }
}
