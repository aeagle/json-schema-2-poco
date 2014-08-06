//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace generated
{
    using System;
    using com.cvent.country.entities;
    using generated;
    using System.Collections.Generic;
    using Cvent.SchemaToPoco.Core.ValidationAttributes;
    using System.ComponentModel.DataAnnotations;
    
    
    // A nation with its own government, occupying a particular territory
    public class Country
    {
        
        // Used as the symbol or emblem of a country
        private Flag _flag;
        
        // A large town
        private HashSet<City> _cities;
        
        // The number of people inhabiting this country
        private int _population;
        
        // Used as the symbol or emblem of a country
        public virtual Flag Flag
        {
            get
            {
                return _flag;
            }
            set
            {
                _flag = value;
            }
        }
        
        // A large town
        public virtual HashSet<City> Cities
        {
            get
            {
                return _cities;
            }
            set
            {
                _cities = value;
            }
        }
        
        // The number of people inhabiting this country
        [Required()]
        [MinValue(1000)]
        public virtual int Population
        {
            get
            {
                return _population;
            }
            set
            {
                _population = value;
            }
        }
    }
}