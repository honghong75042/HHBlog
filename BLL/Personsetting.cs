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
	//Personsetting
	///
	public static class PersonsettingManager
	{
		private static Blogo.IDAL.IPersonsetting dal=Blogo.DALFactory.DataAccess.CreatePersonsetting();
		
		public static  PersonsettingEntity SelectPersonsettingByID(int t_id)
		{
			PersonsettingEntity temp=null;
			try
			{
				temp=dal.SelectPersonsettingByID( t_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<PersonsettingEntity> GetAllPersonsetting()
		{
			IList<PersonsettingEntity> temp=null;
			try
			{
				temp=GetAllPersonsetting();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<PersonsettingEntity> GetAllPersonsettingByauthor_id(int t_author_id)
		{
			IList<PersonsettingEntity> temp=null;
			try
			{
				temp=GetAllPersonsettingByauthor_id(t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		public static IList<PersonsettingEntity> GetAllPersonsettingBymodel_id(int t_model_id)
		{
			IList<PersonsettingEntity> temp=null;
			try
			{
				temp=GetAllPersonsettingBymodel_id(t_model_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertPersonsetting(PersonsettingEntity t_Personsetting)
		{		
			int i=-1;
			try
			{
				i=InsertPersonsetting(t_Personsetting);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdatePersonsetting(PersonsettingEntity t_Personsetting)
		{
			int i=-1;
			try
			{
				i=UpdatePersonsetting(t_Personsetting);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeletePersonsetting(int t_id)
		{
			int i=-1;
			try
			{
				i=DeletePersonsetting(t_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


