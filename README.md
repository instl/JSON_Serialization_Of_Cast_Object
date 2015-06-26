JSON Serialization Of Cast Object
=============================

Interesting issue where JSON serliazation reflects on the base object in memory opposed to the down cast object type. The end result is technically incorrect JSON, as properties that would not be accessable in C# are now shown.
