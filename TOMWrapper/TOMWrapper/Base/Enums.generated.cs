
// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using System.Drawing.Design;
using TOM = Microsoft.AnalysisServices.Tabular;
namespace TabularEditor.TOMWrapper
{
	public enum DataSourceType {    
        Provider = 1,
	}
	public enum PartitionSourceType {    
        Query = 1,
        Calculated = 2,
        None = 3,
	}
	public enum DataType {    
        Automatic = 1,
        String = 2,
        Int64 = 6,
        Double = 8,
        DateTime = 9,
        Decimal = 10,
        Boolean = 11,
        Binary = 17,
        Unknown = 19,
        Variant = 20,
	}
	public enum ObjectState {    
        Ready = 1,
        NoData = 3,
        CalculationNeeded = 4,
        SemanticError = 5,
        EvaluationError = 6,
        DependencyError = 7,
        Incomplete = 8,
	}
	public enum Alignment {    
        Default = 1,
        Left = 2,
        Right = 3,
        Center = 4,
	}
	public enum AggregateFunction {    
        Default = 1,
        None = 2,
        Sum = 3,
        Min = 4,
        Max = 5,
        Count = 6,
        Average = 7,
        DistinctCount = 8,
	}
	public enum ColumnType {    
        Data = 1,
        Calculated = 2,
        RowNumber = 3,
        CalculatedTableColumn = 4,
	}
	public enum RoleMemberType {    
        Auto = 1,
        User = 2,
        Group = 3,
	}
	public enum ModeType {    
        Import = 0,
        DirectQuery = 1,
        Default = 2,
	}
	public enum DataViewType {    
        Full = 0,
        Sample = 1,
        Default = 3,
	}
	public enum ModelPermission {    
        None = 1,
        Read = 2,
        ReadRefresh = 3,
        Refresh = 4,
        Administrator = 5,
	}
	public enum ImpersonationMode {    
        Default = 1,
        ImpersonateAccount = 2,
        ImpersonateAnonymous = 3,
        ImpersonateCurrentUser = 4,
        ImpersonateServiceAccount = 5,
        ImpersonateUnattendedAccount = 6,
	}
	public enum DatasourceIsolation {    
        ReadCommitted = 1,
        Snapshot = 2,
	}
	public enum RelationshipType {    
        SingleColumn = 1,
	}
	public enum CrossFilteringBehavior {    
        OneDirection = 1,
        BothDirections = 2,
        Automatic = 3,
	}
	public enum SecurityFilteringBehavior {    
        OneDirection = 1,
        BothDirections = 2,
	}
	public enum DateTimeRelationshipBehavior {    
        DateAndTime = 1,
        DatePartOnly = 2,
	}
	public enum RelationshipEndCardinality {    
        None = 0,
        One = 1,
        Many = 2,
	}
}
