using System;

public class DataItem
{
	string Id { get; set; }
	byte[] Payload { get; set; }

	public DataItem(string id, byte[] payload)
	{
		Id = id;
		Payload = payload;
    }

	public int GetSize()
	{
		return Payload.Length;
    }
}
