using System.Linq;
using System;
using List;
using UnityEngine;

public class Log : MonoBehaviour {
	private List<string> logList { get; set; }

	public Log()
	{
		this.logList = new ArrayList<string>();
	}

	public addLogEntry(string logEntry) {
		this.logList.append(logEntry);
	}
}