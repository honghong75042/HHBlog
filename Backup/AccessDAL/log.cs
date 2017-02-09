///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.OleDb;
using System;

using Blogo.Model;
using Blogo.DBUtility;
using Blogo.IDAL;


namespace Blogo.AccessDAL
{
	///
	//Log
	///
	public class Log:ILog
	{
		public  LogEntity SelectLogByID(int t_id)
		{
			LogEntity t_Log=new LogEntity();
			OleDbDataReader sdr =null;
			using(sdr=OLEDBHelp.GetReader("select * from Logs where id="+t_id))
			{
				if(sdr.Read())
				{
					t_Log.Id=(int)sdr.GetValue(0);
					t_Log.Author_id=(int)sdr.GetValue(1);
					t_Log.Date=(DateTime)sdr.GetValue(2);
					t_Log.Opevent=(string)sdr.GetValue(3);
					
				}
				
			}
			sdr.Close();
			
			return t_Log;
		}
		
		public IList<LogEntity> GetAllLog()
		{
			IList<LogEntity> t_Logs=new List<LogEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Logs"))
			{
				while(sdr.Read())
				{
					LogEntity t_Log=new LogEntity();
					t_Log.Id=(int)sdr.GetValue(0);					
					t_Log.Author_id=(int)sdr.GetValue(1);					
					t_Log.Date=(DateTime)sdr.GetValue(2);					
					t_Log.Opevent=(string)sdr.GetValue(3);					
					t_Logs.Add(t_Log);
				}
				sdr.Close();
			}
			
			return t_Logs;
		}
		
		
		public IList<LogEntity> GetAllLogByauthor_id(int t_author_id)
		{
			IList<LogEntity> t_Logs=new List<LogEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Logs where author_id="+t_author_id))
			{
				while(sdr.Read())
				{
					LogEntity t_Log=new LogEntity();
					t_Log.Id=(int)sdr.GetValue(0);
					t_Log.Author_id=(int)sdr.GetValue(1);
					t_Log.Date=(DateTime)sdr.GetValue(2);
					t_Log.Opevent=(string)sdr.GetValue(3);
					t_Logs.Add(t_Log);
				}
				sdr.Close();
			}
			
			return t_Logs;
		}
	
		public  int InsertLog(LogEntity t_Log)
		{			
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Id",t_Log.Id),					
				new OleDbParameter("@Author_id",t_Log.Author_id),					
				new OleDbParameter("@Date",t_Log.Date),					
				new OleDbParameter("@Opevent",t_Log.Opevent)				
				
			};
			
			int i=OLEDBHelp.GetExecute("insert into Logs values(@Id,@Author_id,@Date,@Opevent)",p);
			return i;				
		}
		
		public  int UpdateLog(LogEntity t_Log)
		{
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Id",t_Log.Id),					
				new OleDbParameter("@Author_id",t_Log.Author_id),					
				new OleDbParameter("@Date",t_Log.Date),					
				new OleDbParameter("@Opevent",t_Log.Opevent)				
				
			};
			
			int i=OLEDBHelp.GetExecute("update Logs set author_id=@Author_id,date=@Date,opevent=@Opevent where id=@Id",p);
			return i;	
		}
		
		public  int DeleteLog(int t_id)
		{
			int i=OLEDBHelp.GetExecute("delete from Logs where id="+t_id);
			return i;
		}
	}
}


