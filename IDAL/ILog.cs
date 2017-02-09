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


namespace Blogo.IDAL
{
	///
	//Log
	///
	public interface ILog
	{
		 LogEntity SelectLogByID(int t_id);
		
		 IList<LogEntity> GetAllLog();
				
		 IList<LogEntity> GetAllLogByauthor_id(int t_author_id);
		
	
		  int InsertLog(LogEntity t_Log);
		
		  int UpdateLog(LogEntity t_Log);
		
		  int DeleteLog(int t_id);
	}
}


