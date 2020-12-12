using System.Linq;
using System;
using UnityEngine;
using System.Collections.Generic;

public class Log : MonoBehaviour {
	private List<string> logList { get; set; }

	public Log()
	{
		this.logList = new List<string>();
	}

	public void addLogEntry(string logEntry) {
		this.logList.Append(logEntry);
	}
}