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
	//Blogotype
	///
	public static class BlogotypeManager
	{
		private static Blogo.IDAL.IBlogotype dal=Blogo.DALFactory.DataAccess.CreateBlogotype();
		
		public static  BlogotypeEntity SelectBlogotypeByID(int t_blogtype_id)
		{
			BlogotypeEntity temp=null;
			try
			{
				temp=dal.SelectBlogotypeByID( t_blogtype_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<BlogotypeEntity> GetAllBlogotype()
		{
			IList<BlogotypeEntity> temp=null;
			try
			{
				temp=GetAllBlogotype();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<BlogotypeEntity> GetAllBlogotypeByauthor_id(int t_author_id)
		{
			IList<BlogotypeEntity> temp=null;
			try
			{
				temp=GetAllBlogotypeByauthor_id(t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertBlogotype(BlogotypeEntity t_Blogotype)
		{		
			int i=-1;
			try
			{
				i=InsertBlogotype(t_Blogotype);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateBlogotype(BlogotypeEntity t_Blogotype)
		{
			int i=-1;
			try
			{
				i=UpdateBlogotype(t_Blogotype);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteBlogotype(int t_blogtype_id)
		{
			int i=-1;
			try
			{
				i=DeleteBlogotype(t_blogtype_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


