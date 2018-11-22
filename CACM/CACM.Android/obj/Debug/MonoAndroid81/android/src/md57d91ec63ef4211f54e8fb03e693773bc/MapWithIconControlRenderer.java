package md57d91ec63ef4211f54e8fb03e693773bc;


public class MapWithIconControlRenderer
	extends md55b943cb46934695d066180d3c9f40d32.MapRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CACM.Droid.MapWithIconControlRenderer, CACM.Android", MapWithIconControlRenderer.class, __md_methods);
	}


	public MapWithIconControlRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MapWithIconControlRenderer.class)
			mono.android.TypeManager.Activate ("CACM.Droid.MapWithIconControlRenderer, CACM.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MapWithIconControlRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MapWithIconControlRenderer.class)
			mono.android.TypeManager.Activate ("CACM.Droid.MapWithIconControlRenderer, CACM.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MapWithIconControlRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MapWithIconControlRenderer.class)
			mono.android.TypeManager.Activate ("CACM.Droid.MapWithIconControlRenderer, CACM.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
