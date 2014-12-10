﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Bug2Bug
{
    public class AuthorModel
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
    	public string LastName{get;set;}
	    public AuthorModel(){}
	    public override string ToString(){
            return String.Format("{0}  {1}", FirstName, LastName);
	    }
    }
}