using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.重写object的成员
{
    /// <summary>
    /// 
    /// </summary>
    struct Coordinate
    {
        /// <summary>
        /// 
        /// </summary>
        public string strLongitude { get; }
        /// <summary>
        /// 
        /// </summary>
        public string strLatitude { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public Coordinate(string longitude, string latitude)
        {
            this.strLatitude = latitude;
            this.strLongitude = longitude;
        }

        #region 重写 ToString()
        /*
         
            ToString()默认返回类的完全限定名称,例如 System.IO.FileStream的对象调用ToString(),
            返回字符串"System.IO.FileStream"

            设计规范
               如果返回有用的，面向开发人员的诊断字符串，就要重写ToString()。
               要使ToString()返回的字符串简短。
               不要从ToString()返回空字符串来表示空(null)。
               避免ToString()引发异常或造成可观察到的副作用(改变对象状态)。
               如果返回值与语言文化相关或要求格式化(例如DateTime),
                   就要重载ToString(string format)或实现IFormattable。
               考虑从ToString()返回一个独一无二的字符串以标识对象实例。
        */
        public override string ToString()
        {
            return $"{ strLongitude } { strLatitude }";
        }
        #endregion

        #region 重写 GetHashCode()
        /*
         
            实现原则
                必须：相等的对象必然有相等的哈希码（如果a.Equals(b),则a.GetHashCode() == b.GetHashCode()）
                必须：在特定对象的生存期内，GetHashCode()始终返回相同的值，即使对象的数据发生了变化。
                        许多时候应缓存方法的返回值，从而确保这一点。
                必须：GetHashCode()不应该引发任何异常；GetHashCode()总是成功返回一个值
                性能：哈希码应尽可能唯一。但由于哈希码只是返回一个int,所以只要一种对象包含的值比一个int能够容纳得多，
                        那么哈希码肯定存在重复，假设每个int值都只能标识一个不同的long值，肯定有大量的long值没法标识。
                性能：可能的哈希码值应当在int的范围内平均分布。
                        例如，创建哈希码时如果没有考虑到字符串在拉丁语言中的分布主要集中在初始的128个ASCII字符上，
                            就会造成字符创值的分布非常不平均。
                性能：GetHashCode()的性能应该优化。通常在Equals()实现中用于"短路",
                        当类型作为字典集合中的键类型使用时，会频繁调用该方法。
                性能：两个对象的细微差异应造成哈希值的极大差异。理想状态下，1 bit的差异应造成哈希码平均16 bits的差异，
                        这有助于确保不管哈希表如何对哈希值进行"桶装"，也能保持良好的平衡性。
                安全性：攻击者应难以伪造具有特定哈希码的对象。攻击手法是向哈希表中填写大量哈希为同一个值得数据。
                          如果哈希表的实现不够高效，易于受到DOS(拒绝服务)攻击。
             */
        public override int GetHashCode()
        {
            int hashCode = strLongitude.GetHashCode();
            if (strLongitude.GetHashCode() != strLatitude.GetHashCode())
            {
                hashCode ^= strLatitude.GetHashCode();//OR
            }
            return hashCode;
        }
        #endregion

        #region 重写 Equals()
        /*
            
             object.Equals()的实现只是简单调用了ReferenceEquals()。

             实现原则
                检查是否为null。
                如果是引用类型，就检查引用是否相等。
                检查数据类型是否相同。
                调用一个指定了具体类型的辅助方法，它的操作数是具体要比较的类型而不是object
                可能要检查哈希码是否相等来短路一次全面的、逐字段的比较。(两个相等的对象不可能哈希码不同)
                如基类重写了Equals(),就建厂base.Equlas()。
                比较每一个标识字段（关键字段），判断是否相等。
                重写GetHashCode()。
                重写 == 和 != 操作符。
            设计规范
                要一起实现GetHashCode()、Equals()、== 操作符和 != 操作符，缺一不可。
                要用相同算法实现Equals()、== 和 !=。
                避免在GetHashCode()、Equals()、== 和 != 的实现中引发异常。
                避免在可变引用类型上重载相等性操作符（比如重载的实现速度过慢，也不要重载）。
                要在实现IComparable时实现与相等性相关的所有方法。
             */
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((Coordinate)obj);
        }
        //如果为 private 则 this.GetType() != obj.GetType() 可以省略
        public bool Equals(Coordinate obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (this.GetHashCode() != obj.GetHashCode())
            {
                return false;
            }
            if (!base.Equals(obj))
            {
                return false;
            }
            return (strLongitude.Equals(strLongitude)) && (strLatitude.Equals(strLatitude));

        }
        #endregion

        #region 操作符重载
        /*
            注意事项
                一定不要用相等性操作符执行空检查（leftCoordinate == null）,否则会递归调用方法。
                应调用ReferenceEquals()检查是否为空。
         */
        public static bool operator ==(Coordinate leftCoordinate, Coordinate rightCorrdinate)
        {
            if (ReferenceEquals(leftCoordinate, null))
            {
                return ReferenceEquals(rightCorrdinate, null);
            }
            return leftCoordinate.Equals(rightCorrdinate);
        }


        public static bool operator !=(Coordinate leftCoordinate, Coordinate rightCorrdinate)
        {
            return !(leftCoordinate == rightCorrdinate);
        }
        #endregion



    }
}
