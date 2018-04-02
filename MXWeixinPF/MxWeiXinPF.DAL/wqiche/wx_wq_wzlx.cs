﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MxWeiXinPF.DBUtility;//Please add references
namespace MxWeiXinPF.DAL
{
	/// <summary>
	/// 数据访问类:wx_wq_wzlx
	/// </summary>
	public partial class wx_wq_wzlx
	{
		public wx_wq_wzlx()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MxWeiXinPF.Model.wx_wq_wzlx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wx_wq_wzlx(");
			strSql.Append("Id,cxid,yhid,escid,pxcid,lbsid,sort_id,createdate,wid)");
			strSql.Append(" values (");
			strSql.Append("@Id,@cxid,@yhid,@escid,@pxcid,@lbsid,@sort_id,@createdate,@wid)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@cxid", SqlDbType.Int,4),
					new SqlParameter("@yhid", SqlDbType.Int,4),
					new SqlParameter("@escid", SqlDbType.Int,4),
					new SqlParameter("@pxcid", SqlDbType.Int,4),
					new SqlParameter("@lbsid", SqlDbType.Int,4),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@createdate", SqlDbType.DateTime),
					new SqlParameter("@wid", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.cxid;
			parameters[2].Value = model.yhid;
			parameters[3].Value = model.escid;
			parameters[4].Value = model.pxcid;
			parameters[5].Value = model.lbsid;
			parameters[6].Value = model.sort_id;
			parameters[7].Value = model.createdate;
			parameters[8].Value = model.wid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MxWeiXinPF.Model.wx_wq_wzlx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wx_wq_wzlx set ");
			strSql.Append("Id=@Id,");
			strSql.Append("cxid=@cxid,");
			strSql.Append("yhid=@yhid,");
			strSql.Append("escid=@escid,");
			strSql.Append("pxcid=@pxcid,");
			strSql.Append("lbsid=@lbsid,");
			strSql.Append("sort_id=@sort_id,");
			strSql.Append("createdate=@createdate,");
			strSql.Append("wid=@wid");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@cxid", SqlDbType.Int,4),
					new SqlParameter("@yhid", SqlDbType.Int,4),
					new SqlParameter("@escid", SqlDbType.Int,4),
					new SqlParameter("@pxcid", SqlDbType.Int,4),
					new SqlParameter("@lbsid", SqlDbType.Int,4),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@createdate", SqlDbType.DateTime),
					new SqlParameter("@wid", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.cxid;
			parameters[2].Value = model.yhid;
			parameters[3].Value = model.escid;
			parameters[4].Value = model.pxcid;
			parameters[5].Value = model.lbsid;
			parameters[6].Value = model.sort_id;
			parameters[7].Value = model.createdate;
			parameters[8].Value = model.wid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from wx_wq_wzlx ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MxWeiXinPF.Model.wx_wq_wzlx GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,cxid,yhid,escid,pxcid,lbsid,sort_id,createdate,wid from wx_wq_wzlx ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MxWeiXinPF.Model.wx_wq_wzlx model=new MxWeiXinPF.Model.wx_wq_wzlx();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MxWeiXinPF.Model.wx_wq_wzlx DataRowToModel(DataRow row)
		{
			MxWeiXinPF.Model.wx_wq_wzlx model=new MxWeiXinPF.Model.wx_wq_wzlx();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["cxid"]!=null && row["cxid"].ToString()!="")
				{
					model.cxid=int.Parse(row["cxid"].ToString());
				}
				if(row["yhid"]!=null && row["yhid"].ToString()!="")
				{
					model.yhid=int.Parse(row["yhid"].ToString());
				}
				if(row["escid"]!=null && row["escid"].ToString()!="")
				{
					model.escid=int.Parse(row["escid"].ToString());
				}
				if(row["pxcid"]!=null && row["pxcid"].ToString()!="")
				{
					model.pxcid=int.Parse(row["pxcid"].ToString());
				}
				if(row["lbsid"]!=null && row["lbsid"].ToString()!="")
				{
					model.lbsid=int.Parse(row["lbsid"].ToString());
				}
				if(row["sort_id"]!=null && row["sort_id"].ToString()!="")
				{
					model.sort_id=int.Parse(row["sort_id"].ToString());
				}
				if(row["createdate"]!=null && row["createdate"].ToString()!="")
				{
					model.createdate=DateTime.Parse(row["createdate"].ToString());
				}
				if(row["wid"]!=null && row["wid"].ToString()!="")
				{
					model.wid=int.Parse(row["wid"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,cxid,yhid,escid,pxcid,lbsid,sort_id,createdate,wid ");
			strSql.Append(" FROM wx_wq_wzlx ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,cxid,yhid,escid,pxcid,lbsid,sort_id,createdate,wid ");
			strSql.Append(" FROM wx_wq_wzlx ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM wx_wq_wzlx ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from wx_wq_wzlx T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "wx_wq_wzlx";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

