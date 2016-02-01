namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>Collection of test data to be used with the <see cref="ClassDataAttribute"/>.</summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public abstract class ConstructorTestDataCollectionBase : IEnumerable<ConstructorTestParameters[]>
    {
        protected virtual IEnumerable<ConstructorTestParameters[]> Data { get; }

        /// <summary>
        ///     Exposes the enumerator, which supports a simple iteration
        ///     over a collection of <see cref="ConstructorTestParameters"/>.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<ConstructorTestParameters[]> GetEnumerator()
        {
            return Data.GetEnumerator();
        }

        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Data.GetEnumerator();
        }
    }
}