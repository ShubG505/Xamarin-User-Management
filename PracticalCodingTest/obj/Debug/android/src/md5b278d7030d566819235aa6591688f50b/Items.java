package md5b278d7030d566819235aa6591688f50b;


public class Items
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("PracticalCodingTest.Items, PracticalCodingTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Items.class, __md_methods);
	}


	public Items () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Items.class)
			mono.android.TypeManager.Activate ("PracticalCodingTest.Items, PracticalCodingTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
