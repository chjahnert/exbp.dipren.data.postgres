﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EXBP.Dipren.Data.Postgres {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PostgresEngineDataStoreImplementationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PostgresEngineDataStoreImplementationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EXBP.Dipren.Data.Postgres.PostgresEngineDataStoreImplementationResources", typeof(PostgresEngineDataStoreImplementationResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  (SELECT COUNT(1) FROM &quot;dipren&quot;.&quot;jobs&quot; WHERE (&quot;id&quot; = @job_id)) AS &quot;job_count&quot;,
        ///  (SELECT COUNT(1) FROM &quot;dipren&quot;.&quot;partitions&quot; WHERE (&quot;job_id&quot; = @job_id) AND (&quot;is_completed&quot; = FALSE)) AS &quot;partition_count&quot;;.
        /// </summary>
        internal static string QueryCountIncompletePartitions {
            get {
                return ResourceManager.GetString("QueryCountIncompletePartitions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  COUNT(1) AS &quot;count&quot;
        ///FROM
        ///  &quot;dipren&quot;.&quot;jobs&quot;;.
        /// </summary>
        internal static string QueryCountJobs {
            get {
                return ResourceManager.GetString("QueryCountJobs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  COUNT(1) AS &quot;count&quot;
        ///FROM
        ///  &quot;dipren&quot;.&quot;jobs&quot;
        ///WHERE
        ///  (&quot;id&quot; = @id);.
        /// </summary>
        internal static string QueryDoesJobExist {
            get {
                return ResourceManager.GetString("QueryDoesJobExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  COUNT(1) AS &quot;count&quot;
        ///FROM
        ///  &quot;dipren&quot;.&quot;partitions&quot;
        ///WHERE
        ///  (&quot;id&quot; = @id);.
        /// </summary>
        internal static string QueryDoesPartitionExist {
            get {
                return ResourceManager.GetString("QueryDoesPartitionExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO &quot;dipren&quot;.&quot;jobs&quot;
        ///(
        ///  &quot;id&quot;,
        ///  &quot;created&quot;,
        ///  &quot;updated&quot;,
        ///  &quot;batch_size&quot;,
        ///  &quot;timeout&quot;,
        ///  &quot;clock_drift&quot;,
        ///  &quot;started&quot;,
        ///  &quot;completed&quot;,
        ///  &quot;state&quot;,
        ///  &quot;error&quot;
        ///)
        ///VALUES
        ///(
        ///  @id,
        ///  @created,
        ///  @updated,
        ///  @batch_size,
        ///  @timeout,
        ///  @clock_drift,
        ///  @started,
        ///  @completed,
        ///  @state,
        ///  @error
        ///);.
        /// </summary>
        internal static string QueryInsertJob {
            get {
                return ResourceManager.GetString("QueryInsertJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO &quot;dipren&quot;.&quot;partitions&quot;
        ///(
        ///  &quot;id&quot;,
        ///  &quot;job_id&quot;,
        ///  &quot;created&quot;,
        ///  &quot;updated&quot;,
        ///  &quot;owner&quot;,
        ///  &quot;first&quot;,
        ///  &quot;last&quot;,
        ///  &quot;is_inclusive&quot;,
        ///  &quot;position&quot;,
        ///  &quot;processed&quot;,
        ///  &quot;remaining&quot;,
        ///  &quot;throughput&quot;,
        ///  &quot;is_completed&quot;,
        ///  &quot;is_split_requested&quot;
        ///)
        ///VALUES
        ///(
        ///  @id,
        ///  @job_id,
        ///  @created,
        ///  @updated,
        ///  @owner,
        ///  @first,
        ///  @last,
        ///  @is_inclusive,
        ///  @position,
        ///  @processed,
        ///  @remaining,
        ///  @throughput,
        ///  @is_completed,
        ///  @is_split_requested
        ///);.
        /// </summary>
        internal static string QueryInsertPartition {
            get {
                return ResourceManager.GetString("QueryInsertPartition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE
        ///  &quot;dipren&quot;.&quot;jobs&quot;
        ///SET
        ///  &quot;updated&quot; = @timestamp,
        ///  &quot;completed&quot; = @timestamp,
        ///  &quot;state&quot; = @state
        ///WHERE
        ///  (&quot;id&quot; = @id)
        ///RETURNING
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;batch_size&quot; AS &quot;batch_size&quot;,
        ///  &quot;timeout&quot; AS &quot;timeout&quot;,
        ///  &quot;clock_drift&quot; AS &quot;clock_drift&quot;,
        ///  &quot;started&quot; AS &quot;started&quot;,
        ///  &quot;completed&quot; AS &quot;completed&quot;,
        ///  &quot;state&quot; AS &quot;state&quot;,
        ///  &quot;error&quot; AS &quot;error&quot;;.
        /// </summary>
        internal static string QueryMarkJobAsCompleted {
            get {
                return ResourceManager.GetString("QueryMarkJobAsCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE
        ///  &quot;dipren&quot;.&quot;jobs&quot;
        ///SET
        ///  &quot;updated&quot; = @timestamp,
        ///  &quot;state&quot; = @state,
        ///  &quot;error&quot; = @error
        ///WHERE
        ///  (&quot;id&quot; = @id)
        ///RETURNING
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;batch_size&quot; AS &quot;batch_size&quot;,
        ///  &quot;timeout&quot; AS &quot;timeout&quot;,
        ///  &quot;clock_drift&quot; AS &quot;clock_drift&quot;,
        ///  &quot;started&quot; AS &quot;started&quot;,
        ///  &quot;completed&quot; AS &quot;completed&quot;,
        ///  &quot;state&quot; AS &quot;state&quot;,
        ///  &quot;error&quot; AS &quot;error&quot;;.
        /// </summary>
        internal static string QueryMarkJobAsFailed {
            get {
                return ResourceManager.GetString("QueryMarkJobAsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE
        ///  &quot;dipren&quot;.&quot;jobs&quot;
        ///SET
        ///  &quot;updated&quot; = @timestamp,
        ///  &quot;state&quot; = @state
        ///WHERE
        ///  (&quot;id&quot; = @id)
        ///RETURNING
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;batch_size&quot; AS &quot;batch_size&quot;,
        ///  &quot;timeout&quot; AS &quot;timeout&quot;,
        ///  &quot;clock_drift&quot; AS &quot;clock_drift&quot;,
        ///  &quot;started&quot; AS &quot;started&quot;,
        ///  &quot;completed&quot; AS &quot;completed&quot;,
        ///  &quot;state&quot; AS &quot;state&quot;,
        ///  &quot;error&quot; AS &quot;error&quot;;.
        /// </summary>
        internal static string QueryMarkJobAsReady {
            get {
                return ResourceManager.GetString("QueryMarkJobAsReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE
        ///  &quot;dipren&quot;.&quot;jobs&quot;
        ///SET
        ///  &quot;updated&quot; = @timestamp,
        ///  &quot;started&quot; = @timestamp,
        ///  &quot;state&quot; = @state
        ///WHERE
        ///  (&quot;id&quot; = @id)
        ///RETURNING
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;batch_size&quot; AS &quot;batch_size&quot;,
        ///  &quot;timeout&quot; AS &quot;timeout&quot;,
        ///  &quot;clock_drift&quot; AS &quot;clock_drift&quot;,
        ///  &quot;started&quot; AS &quot;started&quot;,
        ///  &quot;completed&quot; AS &quot;completed&quot;,
        ///  &quot;state&quot; AS &quot;state&quot;,
        ///  &quot;error&quot; AS &quot;error&quot;;.
        /// </summary>
        internal static string QueryMarkJobAsStarted {
            get {
                return ResourceManager.GetString("QueryMarkJobAsStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE
        ///  &quot;dipren&quot;.&quot;partitions&quot;
        ///SET
        ///  &quot;updated&quot; = @updated,
        ///  &quot;position&quot; = @position,
        ///  &quot;processed&quot; = @processed,
        ///  &quot;remaining&quot; = @remaining,
        ///  &quot;throughput&quot; = @throughput,
        ///  &quot;is_completed&quot; = @completed
        ///WHERE
        ///  (&quot;id&quot; = @id) AND
        ///  (&quot;owner&quot; = @owner)
        ///RETURNING
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;job_id&quot; AS &quot;job_id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;owner&quot; AS &quot;owner&quot;,
        ///  &quot;first&quot; AS &quot;first&quot;,
        ///  &quot;last&quot; AS &quot;last&quot;,
        ///  &quot;is_inclusive&quot; AS &quot;is_inclusive&quot;,
        ///  &quot;position&quot; AS &quot;position&quot;,
        ///  &quot;processed&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryReportProgress {
            get {
                return ResourceManager.GetString("QueryReportProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;batch_size&quot; AS &quot;batch_size&quot;,
        ///  &quot;timeout&quot; AS &quot;timeout&quot;,
        ///  &quot;clock_drift&quot; AS &quot;clock_drift&quot;,
        ///  &quot;started&quot; AS &quot;started&quot;,
        ///  &quot;completed&quot; AS &quot;completed&quot;,
        ///  &quot;state&quot; AS &quot;state&quot;,
        ///  &quot;error&quot; AS &quot;error&quot;
        ///FROM
        ///  &quot;dipren&quot;.&quot;jobs&quot;
        ///WHERE
        ///  (&quot;id&quot; = @id);.
        /// </summary>
        internal static string QueryRetrieveJobById {
            get {
                return ResourceManager.GetString("QueryRetrieveJobById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  t1.&quot;id&quot; AS &quot;id&quot;,
        ///  t1.&quot;created&quot; AS &quot;created&quot;,
        ///  t1.&quot;updated&quot; AS &quot;updated&quot;,
        ///  t1.&quot;batch_size&quot; AS &quot;batch_size&quot;,
        ///  t1.&quot;timeout&quot; AS &quot;timeout&quot;,
        ///  t1.&quot;clock_drift&quot; AS &quot;clock_drift&quot;,
        ///  t1.&quot;started&quot; AS &quot;started&quot;,
        ///  t1.&quot;completed&quot; AS &quot;completed&quot;,
        ///  t1.&quot;state&quot; AS &quot;state&quot;,
        ///  t1.&quot;error&quot; AS &quot;error&quot;,
        ///  COUNT(1) FILTER (WHERE (t2.&quot;is_completed&quot; = FALSE) AND (t2.&quot;owner&quot; IS NULL) AND (t2.&quot;processed&quot; = 0)) AS &quot;partitons_untouched&quot;,
        ///  COUNT(1) FILTER (WHERE (t2.&quot;is_completed&quot; = FALSE) AND ((t2.&quot;owner&quot; IS  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRetrieveJobStatusReport {
            get {
                return ResourceManager.GetString("QueryRetrieveJobStatusReport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  &quot;id&quot; AS &quot;id&quot;,
        ///  &quot;job_id&quot; AS &quot;job_id&quot;,
        ///  &quot;created&quot; AS &quot;created&quot;,
        ///  &quot;updated&quot; AS &quot;updated&quot;,
        ///  &quot;owner&quot; AS &quot;owner&quot;,
        ///  &quot;first&quot; AS &quot;first&quot;,
        ///  &quot;last&quot; AS &quot;last&quot;,
        ///  &quot;is_inclusive&quot; AS &quot;is_inclusive&quot;,
        ///  &quot;position&quot; AS &quot;position&quot;,
        ///  &quot;processed&quot; AS &quot;processed&quot;,
        ///  &quot;remaining&quot; AS &quot;remaining&quot;,
        ///  &quot;throughput&quot; AS &quot;throughput&quot;,
        ///  &quot;is_completed&quot; AS &quot;is_completed&quot;,
        ///  &quot;is_split_requested&quot; AS &quot;is_split_requested&quot;
        ///FROM
        ///  &quot;dipren&quot;.&quot;partitions&quot;
        ///WHERE
        ///  (&quot;id&quot; = @id);.
        /// </summary>
        internal static string QueryRetrievePartitionById {
            get {
                return ResourceManager.GetString("QueryRetrievePartitionById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH &quot;candidates&quot; AS
        ///(
        ///  SELECT
        ///    &quot;id&quot;
        ///  FROM
        ///    &quot;dipren&quot;.&quot;partitions&quot;
        ///  WHERE
        ///    (&quot;job_id&quot; = @job_id) AND
        ///    ((&quot;owner&quot; IS NULL) OR (&quot;updated&quot; &lt; @active)) AND
        ///    (&quot;is_completed&quot; = FALSE)
        ///  ORDER BY
        ///    &quot;remaining&quot; DESC
        ///  LIMIT
        ///    @candidates
        ///),
        ///&quot;candidate&quot; AS
        ///(
        ///  SELECT
        ///    t2.&quot;id&quot;
        ///  FROM
        ///    &quot;candidates&quot; AS t1
        ///    INNER JOIN &quot;dipren&quot;.&quot;partitions&quot; AS t2 ON (t1.&quot;id&quot; = t2.&quot;id&quot;)
        ///  WHERE
        ///    (t2.&quot;job_id&quot; = @job_id) AND
        ///    ((t2.&quot;owner&quot; IS NULL) OR (t2.&quot;updated&quot; &lt; @active)) AND
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryTryAcquirePartition {
            get {
                return ResourceManager.GetString("QueryTryAcquirePartition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH &quot;candidates&quot; AS
        ///(
        ///  SELECT
        ///    &quot;id&quot;
        ///  FROM
        ///    &quot;dipren&quot;.&quot;partitions&quot;
        ///  WHERE
        ///    (&quot;job_id&quot; = @job_id) AND
        ///    (&quot;owner&quot; IS NOT NULL) AND
        ///    (&quot;updated&quot; &gt;= @active) AND
        ///    (&quot;is_completed&quot; = FALSE) AND
        ///    (&quot;is_split_requested&quot; = FALSE)
        ///  ORDER BY
        ///    &quot;remaining&quot; DESC
        ///  LIMIT
        ///    @candidates
        ///),
        ///&quot;candidate&quot; AS
        ///(
        ///  SELECT
        ///    t2.&quot;id&quot;
        ///  FROM
        ///    &quot;candidates&quot; AS t1
        ///    INNER JOIN &quot;dipren&quot;.&quot;partitions&quot; AS t2 ON (t1.&quot;id&quot; = t2.&quot;id&quot;)
        ///  WHERE
        ///    (t2.&quot;job_id&quot; = @job_id) AND
        ///    (t2.&quot;owne [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryTryRequestSplit {
            get {
                return ResourceManager.GetString("QueryTryRequestSplit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE
        ///  &quot;dipren&quot;.&quot;partitions&quot;
        ///SET
        ///  &quot;updated&quot; = @updated,
        ///  &quot;last&quot; = @last,
        ///  &quot;is_inclusive&quot; = @is_inclusive,
        ///  &quot;position&quot; = @position,
        ///  &quot;processed&quot; = @processed,
        ///  &quot;remaining&quot; = @remaining,
        ///  &quot;throughput&quot; = @throughput,
        ///  &quot;is_split_requested&quot; = @is_split_requested
        ///WHERE
        ///  (&quot;id&quot; = @partition_id) AND
        ///  (&quot;owner&quot; = @owner);.
        /// </summary>
        internal static string QueryUpdateSplitPartition {
            get {
                return ResourceManager.GetString("QueryUpdateSplitPartition", resourceCulture);
            }
        }
    }
}
