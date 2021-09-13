# Randomator
C# library for generating randomness

I created this library as for one of my projects, I needed to have random "user" data. I plan to add more randomness to this overtime.

Markov capabilities (sentence generator) have been taken from https://github.com/chriscore/MarkovSharp under MIT license.
Thanks to Chris Core for this work. All the code for Markov is in the Markov folder.

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

## Random Identity

`RandomPerson RandomPerson = new RandomPerson();`

## Random Location

Anywhere

`RandomLocation RandomLocation = new RandomLocation();`

In specified country

`RandomLocation RandomLocation = new RandomLocation("Australia");`

In specified country, city

`RandomLocation RandomLocation = new RandomLocation("Australia", "Sydney");`

## Random Phone

Landline, anywhere.

`RandomPhone RandomPhone = new RandomPhone(RandomPhoneType.Land);`

Mobile, anywhere.

`RandomPhone RandomPhone = new RandomPhone(RandomPhoneType.Mobile);`

Landline, in a country.

`RandomPhone RandomPhone = new RandomPhone(RandomPhoneType.Land, "Australia");`

Mobile, in a country.

`RandomPhone RandomPhone = new RandomPhone(RandomPhoneType.Mobile, "Australia");`