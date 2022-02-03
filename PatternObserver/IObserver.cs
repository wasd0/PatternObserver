namespace PatternObserver
{
    interface IObserver<T>
    {
        void Update(T data);
    }
}
