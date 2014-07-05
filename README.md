JSON Serialization Of Cast Object
=============================

Interesting issue where JSON serliazation reflects on the base object in memory opposed to the down cast objec type. The end result is technically incorrect JSON, as properties that would not be accessable in the are now shown.
