[InternalClrError("COR_E_EXECUTIONENGINE: 0x80131506", ErrorStatus.Completed)]
unsafe class E80131506
{
    static void Execute()
    {
        var @object = new object();
        *(nint*)&@object = *(nint*)&@object + 0x10;

        GC.Collect();
    }
}