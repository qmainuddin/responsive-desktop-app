﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Lib.Entity.AccessControl
{
    public class GroupDBEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Target { get; set; }
        public String Status { get; set; }
        public bool IsParentIdSpecified { get; set; }
        public int ParentGroupId { get; set; }
        public bool idSpecified { get; set; }

        public void setParentId(bool isSpecified, int idValue)
        {
            if (isSpecified)
            {
                this.ParentGroupId = idValue;
                this.IsParentIdSpecified = true;
            }
        }
        public int getParentId()
        {
            if (this.IsParentIdSpecified)
            {
                return this.ParentGroupId;
            }
            return Utils.Defs.EMPTY_VALUE;
        }
        public void setId(bool isSpecified, int idValue)
        {
            if (isSpecified)
            {
                this.Id = idValue;
                this.idSpecified = true;
            }
        }
        public int getId()
        {
            if (this.idSpecified)
            {
                return this.Id;
            }
            return Utils.Defs.EMPTY_VALUE;
        }
    }
}
