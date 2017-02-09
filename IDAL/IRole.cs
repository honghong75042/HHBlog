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
	//Role
	///
	public interface IRole
	{
		 RoleEntity SelectRoleByID(int t_role_id);
		
		 IList<RoleEntity> GetAllRole();
				
	
		  int InsertRole(RoleEntity t_Role);
		
		  int UpdateRole(RoleEntity t_Role);
		
		  int DeleteRole(int t_role_id);
	}
}


