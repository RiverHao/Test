using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConTest
{
   public class AskList
    {
        #region 模块属性
        /// <summary>
        /// Unsolved：待解决 Already：已解决 Closed：已关闭 Overdue：过期
        /// </summary>
        public enum StateMode { Unsolved = 0, Already = 1, Closed = 3, Overdue = 4, All = -1 }

        ///<summary>
        ///(int)
        ///</summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DateStr { get; set; }
        ///<summary>
        ///(int)
        ///</summary>
        public int AcceptCount { get; set; }

        ///<summary>
        ///(long)
        ///</summary>
        public long UserId { get; set; }

        ///<summary>
        ///(int)
        ///</summary>
        public int ClassId { get; set; }

        ///<summary>
        ///(int)
        ///</summary>
        public int? ClassId1 { get; set; }

        ///<summary>
        ///(int)
        ///</summary>
        public int? ClassId2 { get; set; }

        ///<summary>
        ///(int)
        ///</summary>
        public int? ClassId3 { get; set; }

        ///<summary>
        ///(short)
        ///</summary>
        public short? Score { get; set; }

        ///<summary>
        ///0：未审核 1：审核通过 2：删除 3：精品
        ///</summary>
        public byte? Verify { get; set; }

        ///<summary>
        ///(short)
        ///</summary>
        public short? AnswerCount { get; set; }
        /// <summary>
        /// 数据统计的回答数
        /// </summary>
        public int? AnswerCountForA { get; set; }

        /// <summary>
        /// 二级分类id
        /// </summary>
        public string classIdStr { get; set; }
        /// <summary>
        /// 二级分类name
        /// </summary>
        public string classNameStr { get; set; }

        ///<summary>
        ///(short)
        ///</summary>
        public short? ViewEndCount { get; set; }

        ///<summary>
        ///0：待解决 1：已解决 3：已关闭 4：过期
        ///</summary>
        public byte? State { get; set; }
        public StateMode StateType
        {
            get { return (StateMode)State; }
        }

        ///<summary>
        ///(string)
        ///</summary>
        public string Sheng { get; set; }

        ///<summary>
        ///(string)
        ///</summary>
        public string City { get; set; }

        ///<summary>
        ///(string)
        ///</summary>
        public string Qu { get; set; }

        ///<summary>
        ///(DateTime)
        ///</summary>
        public DateTime? Date { get; set; }

        ///<summary>
        ///(DateTime)
        ///</summary>
        public DateTime Day { get; set; }

        /// <summary>
        /// 用户回答时间
        /// </summary>
        public DateTime AnswerTime { get; set; }

        ///<summary>
        ///(string)
        ///</summary>
        public string Ip { get; set; }

        ///<summary>
        ///(DateTime)
        ///</summary>
        public DateTime? SearchDate { get; set; }

        ///<summary>
        ///(byte)
        ///</summary>
        public byte? IsAgentList { get; set; }

        /// <summary>
        /// int
        /// </summary>
        public int? viewendcount { get; set; }

        /// <summary>
        /// int
        /// </summary>
        public long? BestAnswerUserId { get; set; }

        /// <summary>
        /// 1：真实提问 0：导入问题
        /// </summary>
        public byte? isreal { get; set; }

        /// <summary>
        /// 楼盘编号
        /// </summary>
        public long? NewCode { get; set; }

        /// <summary>
        /// 商圈
        /// </summary>
        public string Comarea { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        public string District { get; set; }




        ///<summary>
        ///(DateTime)
        ///</summary>
        public string Days { get; set; }

        public int? AskImport { get; set; }
        public int? AnswerImport { get; set; }
        /// <summary>
        /// 是否是用户自定义的类别
        /// </summary>
        public bool? IsClassDefined { get; set; }

        public int? RootClassId { get; set; }

        public int XuanShang { get; set; }
        //扩展属性

        ///// <summary>
        ///// 问题的详细信息
        ///// </summary>
        //public Askdetail Askdetail { get; set; }

        /// <summary>
        /// 问题所属类别名称
        /// </summary>
        public string ClassName { get; set; }
        public string type { get; set; }
        /// <summary>
        /// 提问用户名
        /// </summary>
        public string UserName { get; set; }
        ///// <summary>
        ///// 标题2012年11月13日
        ///// </summary>
        //public string Title { get; set; }
        public int? LifeClassId { get; set; }
        /// <summary>
        /// 来源 0：PC 1：移动
        /// </summary>
        public int Source { get; set; }


        public string UserTitle { get; set; }

        public string UserHeadImage { get; set; }
        public int AskIdCount { get; set; }
        public int AnswerIdCount { get; set; }
        //问答统计
        //日期
        public int Class { get; set; }
        /// <summary>
        /// 每天问题数
        /// </summary>
        public int? AskCount { get; set; }
        //采纳问题
        public int? BestAnswerCount { get; set; }
        //踩的数量
        public int? CaiCount { get; set; }
        //踩的人数
        public int? CaiUserCount { get; set; }
        //顶的数量
        public int? DingCount { get; set; }
        public int? DingUserCount { get; set; }
        //当日问题数
        public float? ToDayAskSum { get; set; }
        //当日有回答的问题数
        public float? TodayAnswerUserCount { get; set; }
        //24小时回答率的问题总数
        public int? ToDayAskSumCount { get; set; }
        //半小时回答率
        public float? HalfHourRateCount { get; set; }


        //总量（新增问题+新增回答）
        public int? NewAddSumCount { get; set; }

        //提问人数
        public int? AskUserCount { get; set; }
        //回答人数
        public int? AnswerUserCount { get; set; }
        //24小时回答率
        public float? TodayAskRateCount { get; set; }
        public float? HalfHourRatess { get; set; }

        //七天采纳率
        public int WeekCaiRate { get; set; }

        //20150316添加
        /// <summary>
        /// 分页
        /// </summary>
        public long RowNumber { get; set; }
        #endregion

        /// <summary>
        /// 获取问题的数量
        /// </summary>
        /// <returns></returns>
        //public static int GetAskListCount()
        //{
            //try
            //{
            //    string cacheKey = "GetAskCountForSearchBar-GetAskListCount";
            //    int temp = Convert.ToInt32(HttpRuntime.Cache[cacheKey]);
            //    if (temp > 0)
            //    {
            //        return temp;
            //    }

            //    ADODatabase db = new ADODatabase(DBConfig.AskReaderD);
            //    DbCommand cmd = db.GetSqlStringCommand("select count(1) from asklist WITH(NOLOCK)");
            //    temp = Convert.ToInt32(db.ExecuteScalar(cmd));
            //    HttpRuntime.Cache.Insert(cacheKey, temp, null, DateTime.Now.AddDays(1), System.Web.Caching.Cache.NoSlidingExpiration);

            //    return temp;
            //}
            //catch
            //{
            //    return 0;
            //}
        //}
    }
}
