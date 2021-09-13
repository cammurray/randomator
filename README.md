# Randomator
C# library for generating randomness

I created this library as for one of my projects, I needed to have random "user" data. I plan to add more randomness to this overtime.

# Current Random information

## Identities

* **Firstname**
* **Lastname**
* **Home Address** *consisting of a location*
* **Work Address** *location in the same city as home address*
* **Home Phone** *Random phone number based on the location of home address*
* **Work Phone** *Random phone number based on the location of work address*

## Locations

* **Street Number** *no verification that these street numbers exist yet*
* **Street Name** *street names exist in the respective city, country*
* **City**
* **Country**

## Phone Numbers

* **Mobile Number** *Mobile phone number that should be in the right format*
* **Phone Number** *Land line phone number that should be in the right format*

# How to use

Generate a random identity

`RandomPerson RandomPerson = new RandomPerson();`


