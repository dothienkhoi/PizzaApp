package crc64a5a37c43dff01024;


public class Border
	extends crc64122dcf5ad656876d.FrameworkElement
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Windows.UI.Xaml.Controls.Border, Uno.UI", Border.class, __md_methods);
	}


	public Border (android.content.Context p0)
	{
		super (p0);
		if (getClass () == Border.class) {
			mono.android.TypeManager.Activate ("Windows.UI.Xaml.Controls.Border, Uno.UI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);

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
