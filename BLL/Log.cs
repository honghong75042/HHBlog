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
	//Log
	///
	public static class LogManager
	{
		private static Blogo.IDAL.ILog dal=Blogo.DALFactory.DataAccess.CreateLog();
		
		public static  LogEntity SelectLogByID(int t_id)
		{
			LogEntity temp=null;
			try
			{
				temp=dal.SelectLogByID( t_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<LogEntity> GetAllLog()
		{
			IList<LogEntity> temp=null;
			try
			{
				temp=GetAllLog();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<LogEntity> GetAllLogByauthor_id(int t_author_id)
		{
			IList<LogEntity> temp=null;
			try
			{
				temp=GetAllLogByauthor_id(t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertLog(LogEntity t_Log)
		{		
			int i=-1;
			try
			{
				i=InsertLog(t_Log);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateLog(LogEntity t_Log)
		{
			int i=-1;
			try
			{
				i=UpdateLog(t_Log);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteLog(int t_id)
		{
			int i=-1;
			try
			{
				i=DeleteLog(t_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


