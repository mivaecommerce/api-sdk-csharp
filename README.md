
# Miva Merchant API SDK for C#

This library wraps the Miva Merchant JSON API introduced in
Miva Merchant 9.12. It allows you to quickly integrate your C#
applications with a Miva Merchant store to fetch, create, and update
store data.

For api documentation visit [https://docs.miva.com/json-api](https://docs.miva.com/json-api).

# Requirements

- Miva Merchant 10.0+
- C# .NET Standard 2.1

**For Miva Merchant 9.x, use the 1.x release**

# Installation

## Via .NET CLI

From your terminal execute the following in your dependent projects directory

`dotnet add package MerchantAPI --version 2.*`

For additional installation methods visit the NuGET package page at [here](https://www.nuget.org/packages/MerchantAPI/) or consult the documentation [here](https://docs.microsoft.com/en-us/nuget/)

## Via Release Package

You can also download the release package from the Releases page or clone the repository directly. To include it in your projects, add the `MerchantAPI/MerchantAPI.csproj` to your project and configure the framework reference of your target to link to the MerchantAPI framework.

# Getting Started

Examples are provided in the `Examples/` directory.

#  SSH Private Key Authentication

## Compatible Private Key Formats

- PKCS#1 PEM Unencrypted
- PKCS#8 PEM Encrypted or Unencrypted
- PKCS#12 (pfx) Encrypted or Unencrypted

## Create PKCS#1 from OpenSSH private key format

If your private key is in OpenSSH format (starts with `-----BEGIN OPENSSH PRIVATE KEY-----`) then you will need to convert it.

Create a copy of your key preserving permissions:

    cp -p /path/to/private/key/id_rsa /path/to/private/key/id_rsa.pem

Convert in place to the proper format:

    ssh-keygen -p -m PEM -f /path/to/private/key/id_rsa.pem

## Create PKCS#8 PEM from PKCS#1 PEM private key format

Converting the key with encryption:

     openssl pkcs8 -in /path/to/private_key.pem -topk8 -out /path/to/private_key.pkcs8.pem

Converting the key without encryption:

     openssl pkcs8 -in /path/to/private_key.pem -topk8 -nocrypt -out /path/to/private_key.pkcs8.pem

## Create X.509 from OpenSSH private key format

If your private key is in OpenSSH format (starts with `-----BEGIN OPENSSH PRIVATE KEY-----`) then you will need to convert it.

Create a copy of your key preserving permissions:

    cp -p /path/to/private/key/id_rsa /path/to/private/key/id_rsa.pem

Convert in place to the proper format:

    ssh-keygen -p -m PEM -f /path/to/private/key/id_rsa.pem

Create a x509 certificate from your private key :

    openssl req -new -key /path/to/private/key/id_rsa.pem -out /path/to/private/key/id_rsa.csr
    
    # We need to specify an expiration, but its ignored 
    openssl req -key /path/to/private/key/id_rsa.pem -new -x509 -days 365 -out /path/to/private/key/id_rsa.crt
    
    openssl pkcs12 -export -out /path/to/private/key/id_rsa.pfx -inkey /path/to/private/key/id_rsa.pem -in /path/to/private/key/id_rsa_converted.crt

## Create X.509 from PKCS#1 PEM private key format

Create a x509 certificate from your private key:

    openssl req -new -key /path/to/private/key/id_rsa.pem -out /path/to/private/key/id_rsa.csr
    
    # We need to specify an expiration, but its ignored 
    openssl req -key /path/to/private/key/id_rsa.pem -new -x509 -days 365 -out /path/to/private/key/id_rsa.crt
    
    openssl pkcs12 -export -out /path/to/private/key/id_rsa.pfx -inkey /path/to/private/key/id_rsa.pem -in /path/to/private/key/id_rsa_converted.crt

# SSH Agent Authentication

## Compatible Public Key Formats

Your public key must be in the OpenSSH Public Key format. The default public key format is usually the correct type if you generated your key using `ssh-keygen`.

See https://tools.ietf.org/html/rfc4253#section-6.6 for format.

A quick way to get the correct format if you have the key associated with your local SSH agent is to run the command `ssh-add -L` and copying the corresponding key.

# License

This library is licensed under the `Miva SDK License Agreement`.

See the `LICENSE` file for more information.