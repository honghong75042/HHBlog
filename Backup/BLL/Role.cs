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
	//Role
	///
	public static class RoleManager
	{
		private static Blogo.IDAL.IRole dal=Blogo.DALFactory.DataAccess.CreateRole();
		
		public static  RoleEntity SelectRoleByID(int t_role_id)
		{
			RoleEntity temp=null;
			try
			{
				temp=dal.SelectRoleByID( t_role_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<RoleEntity> GetAllRole()
		{
			IList<RoleEntity> temp=null;
			try
			{
				temp=GetAllRole();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
	
		public  static int InsertRole(RoleEntity t_Role)
		{		
			int i=-1;
			try
			{
				i=InsertRole(t_Role);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateRole(RoleEntity t_Role)
		{
			int i=-1;
			try
			{
				i=UpdateRole(t_Role);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteRole(int t_role_id)
		{
			int i=-1;
			try
			{
				i=DeleteRole(t_role_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


