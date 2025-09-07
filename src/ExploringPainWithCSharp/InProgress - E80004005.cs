[InternalClrError("E_FAIL: 0x80004005", ErrorStatus.InProcess)]
class E80004005
{
    static void Execute()
    {
        throw new AbandonedMutexException();
    }
}