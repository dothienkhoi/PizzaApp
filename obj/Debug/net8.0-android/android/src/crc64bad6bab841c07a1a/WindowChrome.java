package crc64bad6bab841c07a1a;


public class WindowChrome
	extends crc64a5a37c43dff01024.ContentControl
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Uno.UI.Xaml.Controls.WindowChrome, Uno.UI", WindowChrome.class, __md_methods);
	}


	public WindowChrome (android.content.Context p0)
	{
		super (p0);
		if (getClass () == WindowChrome.class) {
			mono.android.TypeManager.Activate ("Uno.UI.Xaml.Controls.WindowChrome, Uno.UI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}

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
