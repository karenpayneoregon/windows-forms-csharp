# About

A thread safe Singleton class to ensure a SqlConnection is available. Typically this is not wise, there should be a single new connection for each method using a easy to get at connection string.