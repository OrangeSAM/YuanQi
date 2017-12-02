using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using System.Reflection;
using System.Configuration;

namespace DALFactory
{
    public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();

        public static Iactivity Createactivity()
        {
            string className = AssemblyName + "." + db + "activity";
            return (Iactivity)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Iactivity_sign Createactivity_sign()
        {
            string className = AssemblyName + "." + db + "activity_sign";
            return (Iactivity_sign)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Iadmin Createadmin()
        {
            string className = AssemblyName + "." + db + "admin";
            return (Iadmin)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Ialbum Createalbum()
        {
            string className = AssemblyName + "." + db + "album";
            return (Ialbum)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Ialbum_col Createalbum_col()
        {
            string className = AssemblyName + "." + db + "album_col";
            return (Ialbum_col)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Ialbum_photos Createalbum_photos()
        {
            string className = AssemblyName + "." + db + "album_photos";
            return (Ialbum_photos)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Ialphoto_comt Createalphoto_comt()
        {
            string className = AssemblyName + "." + db + "alphotos_comt";
            return (Ialphoto_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Icontest Createconntest()
        {
            string className = AssemblyName + "." + db + "contest";
            return (Icontest)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Icontest_news Createcontest_news()
        {
            string className = AssemblyName + "." + db + "contest_news";
            return (Icontest_news)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Icontest_sign Createcontest_sign()
        {
            string className = AssemblyName + "." + db + "contest_sign";
            return (Icontest_sign)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Idayphoto Createdayphoto()
        {
            string className = AssemblyName + "." + db + "dayphoto";
            return (Idayphoto)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Idayphoto_comt Createdayphoto_comt()
        {
            string className = AssemblyName + "." + db + "dayphoto";
            return (Idayphoto_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Idayphoto_reply Createdayphoto_reply()
        {
            string className = AssemblyName + "." + db + "dayphoto_reply";
            return (Idayphoto_reply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Idiscussion Creatediscussion()
        {
            string className = AssemblyName + "." + db + "discussion";
            return (Idiscussion)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Idiscussion_comt Creatediscussion_comt()
        {
            string className = AssemblyName + "." + db + "discussion_comt";
            return (Idiscussion_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Idiscussion_reply Creatediscussion_reply()
        {
            string className = AssemblyName + "." + db + "discussion_reply";
            return (Idiscussion_reply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Igoods Creategoods()
        {
            string className = AssemblyName + "." + db + "goods";
            return (Igoods)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Igoods_rent Creategoods_rent()
        {
            string className = AssemblyName + "." + db + "goods_rent";
            return (Igoods_rent)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Igoods_type Creategoods_type()
        {
            string className = AssemblyName + "." + db + "goods_type";
            return (Igoods_type)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Iindent Createindent()
        {
            string className = AssemblyName + "." + db + "indent";
            return (Iindent)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Iindent_detail Createindent_detail()
        {
            string className = AssemblyName + "." + db + "indent_datail";
            return (Iindent_detail)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Inewscomt_reply Createnewscomt_reply()
        {
            string className = AssemblyName + "." + db + "newscomt_reply";
            return (Inewscomt_reply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Inews_comt Createnews_comt()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Inews_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Iriderarticle_col Createriderarticle_col()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Iriderarticle_col)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Irider_article Createrider_article()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Irider_article)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Irider_article_comt Createrider_article_comt()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Irider_article_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Irider_article_reply Createrider_article_reply()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Irider_article_reply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Istore Createstore()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Istore)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Istore_comt Createstore_comt()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Istore_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Itravel_comt_reply Createtravel_comt_reply()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Itravel_comt_reply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Itravel_record Createtravel_record()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Itravel_record)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Itravel_record_comt Createtravel_record_comt()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Itravel_record_comt)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Itrrecord Createtrrecord()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Itrrecord)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Itrrecord_col Createtrrecord_col()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Itrrecord_col)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static Iusers Createusers()
        {
            string className = AssemblyName + "." + db + "news_comt";
            return (Iusers)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
