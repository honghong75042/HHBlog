///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

using Blogo.Model;
using Blogo.DBUtility;
using Blogo.IDAL;

using Blogo.SQLServerDAL;
using Blogo.AccessDAL;
using Blogo.DALFactory;



namespace Blogo.BLL
{
	///
	//Comment
	///
	public static class CommentManager
	{
		private static Blogo.IDAL.IComment dal=Blogo.DALFactory.DataAccess.CreateComment();
		
		public static  CommentEntity SelectCommentByID(int t_comment_id)
		{
			CommentEntity temp=null;
			try
			{
				temp=dal.SelectCommentByID( t_comment_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<CommentEntity> GetAllComment()
		{
			IList<CommentEntity> temp=null;
			try
			{
				temp=GetAllComment();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<CommentEntity> GetAllCommentByblog_id(int t_blog_id)
		{
			IList<CommentEntity> temp=null;
			try
			{
				temp=GetAllCommentByblog_id(t_blog_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertComment(CommentEntity t_Comment)
		{		
			int i=-1;
			try
			{
				i=InsertComment(t_Comment);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateComment(CommentEntity t_Comment)
		{
			int i=-1;
			try
			{
				i=UpdateComment(t_Comment);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteComment(int t_comment_id)
		{
			int i=-1;
			try
			{
				i=DeleteComment(t_comment_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


