﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataSourceApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TrainingDataEntities : DbContext
    {
        public TrainingDataEntities()
            : base("name=TrainingDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<ReferenceTime> ReferenceTimes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<GetPersonalRanking_Result> GetPersonalRanking(string athleteName, string eventType, Nullable<System.TimeSpan> swimTime, Nullable<System.TimeSpan> cycleTime, Nullable<System.TimeSpan> runTime, Nullable<System.TimeSpan> overallTime)
        {
            var athleteNameParameter = athleteName != null ?
                new ObjectParameter("AthleteName", athleteName) :
                new ObjectParameter("AthleteName", typeof(string));
    
            var eventTypeParameter = eventType != null ?
                new ObjectParameter("EventType", eventType) :
                new ObjectParameter("EventType", typeof(string));
    
            var swimTimeParameter = swimTime.HasValue ?
                new ObjectParameter("SwimTime", swimTime) :
                new ObjectParameter("SwimTime", typeof(System.TimeSpan));
    
            var cycleTimeParameter = cycleTime.HasValue ?
                new ObjectParameter("CycleTime", cycleTime) :
                new ObjectParameter("CycleTime", typeof(System.TimeSpan));
    
            var runTimeParameter = runTime.HasValue ?
                new ObjectParameter("RunTime", runTime) :
                new ObjectParameter("RunTime", typeof(System.TimeSpan));
    
            var overallTimeParameter = overallTime.HasValue ?
                new ObjectParameter("OverallTime", overallTime) :
                new ObjectParameter("OverallTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPersonalRanking_Result>("GetPersonalRanking", athleteNameParameter, eventTypeParameter, swimTimeParameter, cycleTimeParameter, runTimeParameter, overallTimeParameter);
        }
    
        public virtual ObjectResult<GetReferenceRanking_Result> GetReferenceRanking(string eventType, Nullable<System.TimeSpan> swimTime, Nullable<System.TimeSpan> cycleTime, Nullable<System.TimeSpan> runTime, Nullable<System.TimeSpan> overallTime)
        {
            var eventTypeParameter = eventType != null ?
                new ObjectParameter("EventType", eventType) :
                new ObjectParameter("EventType", typeof(string));
    
            var swimTimeParameter = swimTime.HasValue ?
                new ObjectParameter("SwimTime", swimTime) :
                new ObjectParameter("SwimTime", typeof(System.TimeSpan));
    
            var cycleTimeParameter = cycleTime.HasValue ?
                new ObjectParameter("CycleTime", cycleTime) :
                new ObjectParameter("CycleTime", typeof(System.TimeSpan));
    
            var runTimeParameter = runTime.HasValue ?
                new ObjectParameter("RunTime", runTime) :
                new ObjectParameter("RunTime", typeof(System.TimeSpan));
    
            var overallTimeParameter = overallTime.HasValue ?
                new ObjectParameter("OverallTime", overallTime) :
                new ObjectParameter("OverallTime", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetReferenceRanking_Result>("GetReferenceRanking", eventTypeParameter, swimTimeParameter, cycleTimeParameter, runTimeParameter, overallTimeParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}