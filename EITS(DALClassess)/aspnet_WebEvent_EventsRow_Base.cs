// <fileinfo name="aspnet_WebEvent_EventsRow_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;

namespace IOM.EITS.DAL
{
	/// <summary>
	/// The base class for <see cref="aspnet_WebEvent_EventsRow"/> that 
	/// represents a record in the <c>aspnet_WebEvent_Events</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="aspnet_WebEvent_EventsRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class aspnet_WebEvent_EventsRow_Base
	{
		private string _eventId;
		private System.DateTime _eventTimeUtc;
		private System.DateTime _eventTime;
		private string _eventType;
		private decimal _eventSequence;
		private decimal _eventOccurrence;
		private int _eventCode;
		private int _eventDetailCode;
		private string _message;
		private string _applicationPath;
		private string _applicationVirtualPath;
		private string _machineName;
		private string _requestUrl;
		private string _exceptionType;
		private string _details;

		/// <summary>
		/// Initializes a new instance of the <see cref="aspnet_WebEvent_EventsRow_Base"/> class.
		/// </summary>
		public aspnet_WebEvent_EventsRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>EventId</c> column value.
		/// </summary>
		/// <value>The <c>EventId</c> column value.</value>
		public string EventId
		{
			get { return _eventId; }
			set { _eventId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventTimeUtc</c> column value.
		/// </summary>
		/// <value>The <c>EventTimeUtc</c> column value.</value>
		public System.DateTime EventTimeUtc
		{
			get { return _eventTimeUtc; }
			set { _eventTimeUtc = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventTime</c> column value.
		/// </summary>
		/// <value>The <c>EventTime</c> column value.</value>
		public System.DateTime EventTime
		{
			get { return _eventTime; }
			set { _eventTime = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventType</c> column value.
		/// </summary>
		/// <value>The <c>EventType</c> column value.</value>
		public string EventType
		{
			get { return _eventType; }
			set { _eventType = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventSequence</c> column value.
		/// </summary>
		/// <value>The <c>EventSequence</c> column value.</value>
		public decimal EventSequence
		{
			get { return _eventSequence; }
			set { _eventSequence = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventOccurrence</c> column value.
		/// </summary>
		/// <value>The <c>EventOccurrence</c> column value.</value>
		public decimal EventOccurrence
		{
			get { return _eventOccurrence; }
			set { _eventOccurrence = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventCode</c> column value.
		/// </summary>
		/// <value>The <c>EventCode</c> column value.</value>
		public int EventCode
		{
			get { return _eventCode; }
			set { _eventCode = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EventDetailCode</c> column value.
		/// </summary>
		/// <value>The <c>EventDetailCode</c> column value.</value>
		public int EventDetailCode
		{
			get { return _eventDetailCode; }
			set { _eventDetailCode = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Message</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Message</c> column value.</value>
		public string Message
		{
			get { return _message; }
			set { _message = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ApplicationPath</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ApplicationPath</c> column value.</value>
		public string ApplicationPath
		{
			get { return _applicationPath; }
			set { _applicationPath = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ApplicationVirtualPath</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ApplicationVirtualPath</c> column value.</value>
		public string ApplicationVirtualPath
		{
			get { return _applicationVirtualPath; }
			set { _applicationVirtualPath = value; }
		}

		/// <summary>
		/// Gets or sets the <c>MachineName</c> column value.
		/// </summary>
		/// <value>The <c>MachineName</c> column value.</value>
		public string MachineName
		{
			get { return _machineName; }
			set { _machineName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>RequestUrl</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>RequestUrl</c> column value.</value>
		public string RequestUrl
		{
			get { return _requestUrl; }
			set { _requestUrl = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ExceptionType</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ExceptionType</c> column value.</value>
		public string ExceptionType
		{
			get { return _exceptionType; }
			set { _exceptionType = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Details</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Details</c> column value.</value>
		public string Details
		{
			get { return _details; }
			set { _details = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  EventId=");
			dynStr.Append(EventId);
			dynStr.Append("  EventTimeUtc=");
			dynStr.Append(EventTimeUtc);
			dynStr.Append("  EventTime=");
			dynStr.Append(EventTime);
			dynStr.Append("  EventType=");
			dynStr.Append(EventType);
			dynStr.Append("  EventSequence=");
			dynStr.Append(EventSequence);
			dynStr.Append("  EventOccurrence=");
			dynStr.Append(EventOccurrence);
			dynStr.Append("  EventCode=");
			dynStr.Append(EventCode);
			dynStr.Append("  EventDetailCode=");
			dynStr.Append(EventDetailCode);
			dynStr.Append("  Message=");
			dynStr.Append(Message);
			dynStr.Append("  ApplicationPath=");
			dynStr.Append(ApplicationPath);
			dynStr.Append("  ApplicationVirtualPath=");
			dynStr.Append(ApplicationVirtualPath);
			dynStr.Append("  MachineName=");
			dynStr.Append(MachineName);
			dynStr.Append("  RequestUrl=");
			dynStr.Append(RequestUrl);
			dynStr.Append("  ExceptionType=");
			dynStr.Append(ExceptionType);
			dynStr.Append("  Details=");
			dynStr.Append(Details);
			return dynStr.ToString();
		}
	} // End of aspnet_WebEvent_EventsRow_Base class
} // End of namespace
