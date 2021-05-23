// <copyright file="ICatalogClient.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using Printify.Models;

    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The catalog client interface. <seealso href="https://developers.printify.com/#catalog" />
    /// </summary>
    /// <remarks>
    /// <para>
    /// Through the Catalog resource you can see all of the products, product variants, variant
    /// options and print providers available in the Printify catalog.
    /// </para>
    /// <para>
    /// Products in the Printify catalog are referred to as blueprints (only after user artwork has
    /// been added, are they referred to as products).
    /// </para>
    /// <para>
    /// Every blueprint in the printify catalog has multiple Print Providers that offer that
    /// blueprint. In addition to general differences between Print Providers including location and
    /// print technology employed, each Print Provider also offers different colors, sizes, print
    /// areas and prices.
    /// </para>
    /// <para>
    /// Each Print Provider's blueprint has specific size and color combinations known as variants.
    /// Variants also contain information on a products available print areas and sizes.
    /// </para>
    /// </remarks>
    public interface ICatalogClient
    {
        /// <summary>
        /// <para>Gets the specific blueprint.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/catalog/blueprints/{blueprint_id}.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="blueprintId">The blueprint identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The specific blueprint.</returns>
        /// <example>
        /// { <br /> "id": 3, <br /> "title": "Kids Regular Fit Tee", <br /> "description":
        /// "Description goes here", <br /> "brand": "Delta", <br /> "model": "11736", <br />
        /// "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5cd">https://images.printify.com/5853fe7dce46f30f8327f5cd</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c487ee2a342bc9b8b2fc4d2">https://images.printify.com/5c487ee2a342bc9b8b2fc4d2</a>"
        /// <br /> ] <br />}
        /// </example>
        Task<Blueprint?> GetBlueprint(int blueprintId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Gets the list of available blueprints.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/catalog/blueprints.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The list of available blueprints.</returns>
        /// <example>
        /// [ <br /> { <br /> "id": 3, <br /> "title": "Kids Regular Fit Tee", <br /> "description":
        /// "Description goes here", <br /> "brand": "Delta", <br /> "model": "11736", <br />
        /// "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5cd">https://images.printify.com/5853fe7dce46f30f8327f5cd</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c487ee2a342bc9b8b2fc4d2">https://images.printify.com/5c487ee2a342bc9b8b2fc4d2</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 5, <br /> "title": "Men's Cotton Crew Tee", <br
        /// /> "description": "Description goes here", <br /> "brand": "Next Level", <br /> "model":
        /// "3600", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5a2ffc81b8e7e3656268fb44">https://images.printify.com/5a2ffc81b8e7e3656268fb44</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cdc0126b97b6a00091b58f7">https://images.printify.com/5cdc0126b97b6a00091b58f7</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 6, <br /> "title": "Unisex Heavy Cotton Tee",
        /// <br /> "description": "Description goes here", <br /> "brand": "Gildan", <br /> "model":
        /// "5000", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5a2fd7d9b8e7e36658795dc0">https://images.printify.com/5a2fd7d9b8e7e36658795dc0</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c595436a342bc1670049902">https://images.printify.com/5c595436a342bc1670049902</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c595427a342bc166b6d3002">https://images.printify.com/5c595427a342bc166b6d3002</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5a2fd022b8e7e3666c70623a">https://images.printify.com/5a2fd022b8e7e3666c70623a</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 9, <br /> "title": "Women's Favorite Tee", <br
        /// /> "description": "Description goes here", <br /> "brand": "Bella+Canvas", <br />
        /// "model": "6004", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5a2ffeeab8e7e364d660836f">https://images.printify.com/5a2ffeeab8e7e364d660836f</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e362cab8e7e30a5b0a55bd">https://images.printify.com/59e362cab8e7e30a5b0a55bd</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e362d2b8e7e30b9f576691">https://images.printify.com/59e362d2b8e7e30b9f576691</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e362ddb8e7e3174f3196ee">https://images.printify.com/59e362ddb8e7e3174f3196ee</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e362eab8e7e3593e2ac98d">https://images.printify.com/59e362eab8e7e3593e2ac98d</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 10, <br /> "title": "Women's Flowy Racerback
        /// Tank", <br /> "description": "Description goes here", <br /> "brand": "Bella+Canvas",
        /// <br /> "model": "8800", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5a27eb68b8e7e364d6608322">https://images.printify.com/5a27eb68b8e7e364d6608322</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c485236a342bc521c2a0beb">https://images.printify.com/5c485236a342bc521c2a0beb</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c485217a342bc686053da46">https://images.printify.com/5c485217a342bc686053da46</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c485225a342bc52fe5fee83">https://images.printify.com/5c485225a342bc52fe5fee83</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 11, <br /> "title": "Women's Jersey Short
        /// Sleeve Deep V-Neck Tee", <br /> "description": "Description goes here", <br /> "brand":
        /// "Bella+Canvas", <br /> "model": "6035", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5a27f20fb8e7e316f403a3b1">https://images.printify.com/5a27f20fb8e7e316f403a3b1</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c472ff0a342bcad97372d72">https://images.printify.com/5c472ff0a342bcad97372d72</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c472ff8a342bcad9964d115">https://images.printify.com/5c472ff8a342bcad9964d115</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 12, <br /> "title": "Unisex Jersey Short Sleeve
        /// Tee", <br /> "description": "Description goes here", <br /> "brand": "Bella+Canvas", <br
        /// /> "model": "3001", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5a2ff5b0b8e7e36669068406">https://images.printify.com/5a2ff5b0b8e7e36669068406</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e35414b8e7e30aa625995c">https://images.printify.com/59e35414b8e7e30aa625995c</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cd579548c3769000f274cac">https://images.printify.com/5cd579548c3769000f274cac</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cd579558c37690008453286">https://images.printify.com/5cd579558c37690008453286</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e3541bb8e7e30a60795f9c">https://images.printify.com/59e3541bb8e7e30a60795f9c</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e35428b8e7e30a1a4de812">https://images.printify.com/59e35428b8e7e30a1a4de812</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/59e3552db8e7e3174714887a">https://images.printify.com/59e3552db8e7e3174714887a</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5a8beec5b8e7e304614eb59c">https://images.printify.com/5a8beec5b8e7e304614eb59c</a>"
        /// <br /> ] <br /> } <br />]
        /// </example>
        Task<List<Blueprint>> GetBlueprints(CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Gets the specific print provider and a list of associated blueprint offerings.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/catalog/print_providers/{print_provider_id}.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="printProviderId">The print provider identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The specific print provider and a list of associated blueprint offerings. <br />
        /// </returns>
        /// <example>
        /// { <br /> "id": 1, <br /> "title": "SPOKE Custom Products", <br /> "location": { <br />
        /// "address1": "89 Weirfield St", <br /> "address2": null, <br /> "city": "Brooklyn", <br
        /// /> "country": "US", <br /> "region": "NY", <br /> "zip": "11221-5120" <br /> }, <br />
        /// "blueprints": [ <br /> { <br /> "id": 265, <br /> "title": "Slim Iphone 8", <br />
        /// "brand": "Case Mate", <br /> "model": "Slim Iphone 8", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/59b261c9b8e7e361c9147b1b.png">https://images.printify.com/59b261c9b8e7e361c9147b1b.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 266, <br /> "title": "Tough Iphone 8", <br />
        /// "brand": "Case Mate", <br /> "model": "Tough Iphone 8", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/59b26fbfb8e7e36254554a34.png">https://images.printify.com/59b26fbfb8e7e36254554a34.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 52, <br /> "title": "Slim Iphone 6/6s", <br />
        /// "brand": "Case Mate", <br /> "model": "6/6s Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5eb.png">https://images.printify.com/5853fe7dce46f30f8327f5eb.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5ee.png">https://images.printify.com/5853fe7dce46f30f8327f5ee.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 53, <br /> "title": "Tough Iphone 6/6s", <br />
        /// "brand": "Case Mate", <br /> "model": "6/6s Tough", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5f1.png">https://images.printify.com/5853fe7dce46f30f8327f5f1.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5f4.png">https://images.printify.com/5853fe7dce46f30f8327f5f4.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 54, <br /> "title": "Slim Iphone 6/6s Plus",
        /// <br /> "brand": "Case Mate", <br /> "model": "6/6s Plus Slim", <br /> "images": [ <br />
        /// " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f61b.png">https://images.printify.com/5853fe7dce46f30f8327f61b.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f61e.png">https://images.printify.com/5853fe7dce46f30f8327f61e.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 55, <br /> "title": "Tough Iphone 6/6s Plus",
        /// <br /> "brand": "Case Mate", <br /> "model": "6/6s Plus Tough", <br /> "images": [ <br
        /// /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f615.png">https://images.printify.com/5853fe7dce46f30f8327f615.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f618.png">https://images.printify.com/5853fe7dce46f30f8327f618.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 56, <br /> "title": "Slim Iphone 5/5s/5se", <br
        /// /> "brand": "Case Mate", <br /> "model": "5/5s/5se Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5f7.png">https://images.printify.com/5853fe7dce46f30f8327f5f7.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5fa.png">https://images.printify.com/5853fe7dce46f30f8327f5fa.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 57, <br /> "title": "Tough Iphone 5/5s/5se",
        /// <br /> "brand": "Case Mate", <br /> "model": "5/5s/5se Tough", <br /> "images": [ <br />
        /// " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5fd.png">https://images.printify.com/5853fe7dce46f30f8327f5fd.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f600.png">https://images.printify.com/5853fe7dce46f30f8327f600.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 58, <br /> "title": "Slim Iphone 5C", <br />
        /// "brand": "Case Mate", <br /> "model": "5C Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe80ce46f30f8327f7cf.png">https://images.printify.com/5853fe80ce46f30f8327f7cf.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe80ce46f30f8327f7d7.png">https://images.printify.com/5853fe80ce46f30f8327f7d7.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 59, <br /> "title": "Slim Iphone 4/4s", <br />
        /// "brand": "Case Mate", <br /> "model": "4/4s Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f639.png">https://images.printify.com/5853fe7ece46f30f8327f639.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f63c.png">https://images.printify.com/5853fe7ece46f30f8327f63c.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 60, <br /> "title": "Tough Iphone 4/4s", <br />
        /// "brand": "Case Mate", <br /> "model": "4/4s Tough", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f63f.png">https://images.printify.com/5853fe7ece46f30f8327f63f.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f642.png">https://images.printify.com/5853fe7ece46f30f8327f642.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 61, <br /> "title": "Slim Samsung Galaxy S7",
        /// <br /> "brand": "Case Mate", <br /> "model": "S7 Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f621.png">https://images.printify.com/5853fe7dce46f30f8327f621.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f624.png">https://images.printify.com/5853fe7dce46f30f8327f624.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 62, <br /> "title": "Slim Samsung Galaxy S6",
        /// <br /> "brand": "Case Mate", <br /> "model": "S6 Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f627.png">https://images.printify.com/5853fe7dce46f30f8327f627.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f62a.png">https://images.printify.com/5853fe7ece46f30f8327f62a.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 63, <br /> "title": "Tough Samsung Galaxy S6",
        /// <br /> "brand": "Case Mate", <br /> "model": "S6 Tough", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f62d.png">https://images.printify.com/5853fe7ece46f30f8327f62d.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f630.png">https://images.printify.com/5853fe7ece46f30f8327f630.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 64, <br /> "title": "Slim Samsung Galaxy S5",
        /// <br /> "brand": "Case Mate", <br /> "model": "S5 Slim", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f633.png">https://images.printify.com/5853fe7ece46f30f8327f633.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f636.png">https://images.printify.com/5853fe7ece46f30f8327f636.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 68, <br /> "title": "Mug 11oz", <br /> "brand":
        /// "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d09e78c47045f00083cd10d.png">https://images.printify.com/5d09e78c47045f00083cd10d.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58ac5d64b2439213b51b25ff.png">https://images.printify.com/58ac5d64b2439213b51b25ff.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 69, <br /> "title": "Mug 15oz", <br /> "brand":
        /// "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7bce46f30f8327f4ff.png">https://images.printify.com/5853fe7bce46f30f8327f4ff.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c5c1516a342bcb8e421d242.png">https://images.printify.com/5c5c1516a342bcb8e421d242.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 70, <br /> "title": "Stainless Steel Travel
        /// Mug", <br /> "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> "
        /// <a
        /// href="https://images.printify.com/5d09f7e247045f00083cd110.png">https://images.printify.com/5d09f7e247045f00083cd110.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7bce46f30f8327f502.png">https://images.printify.com/5853fe7bce46f30f8327f502.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58ac0e46b2439209155d3375.png">https://images.printify.com/58ac0e46b2439209155d3375.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58ac5ac0b2439214ad09bd1b.png">https://images.printify.com/58ac5ac0b2439214ad09bd1b.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 71, <br /> "title": "Laptop Sleeve", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7bce46f30f8327f4e2.png">https://images.printify.com/5853fe7bce46f30f8327f4e2.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58ac0dadb2439209e3265564.png">https://images.printify.com/58ac0dadb2439209e3265564.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58ac0db9b24392090e55b2f8.png">https://images.printify.com/58ac0db9b24392090e55b2f8.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58cbdd4eb24392676d7f6961.png">https://images.printify.com/58cbdd4eb24392676d7f6961.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58cbdd67b243926fe26236c2.png">https://images.printify.com/58cbdd67b243926fe26236c2.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 74, <br /> "title": "Spiral Notebook - Ruled
        /// Line", <br /> "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> "
        /// <a
        /// href="https://images.printify.com/5d03643bd155b4000a00cae5.png">https://images.printify.com/5d03643bd155b4000a00cae5.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58cbed76b2439279864551c0.png">https://images.printify.com/58cbed76b2439279864551c0.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58cbf1ddb243926fe909d567.png">https://images.printify.com/58cbf1ddb243926fe909d567.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 75, <br /> "title": "Journal - Ruled Line", <br
        /// /> "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d03aa7dd155b400094c4d60.png">https://images.printify.com/5d03aa7dd155b400094c4d60.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7bce46f30f8327f4de.png">https://images.printify.com/5853fe7bce46f30f8327f4de.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c49c395a342bc53475e5412.png">https://images.printify.com/5c49c395a342bc53475e5412.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 76, <br /> "title": "Journal - Blank", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d03aad4d155b4000a00cb82.png">https://images.printify.com/5d03aad4d155b4000a00cb82.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/585a7e24ce46f3416b5db1c7.png">https://images.printify.com/585a7e24ce46f3416b5db1c7.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c49c3cba342bc53c0283808.png">https://images.printify.com/5c49c3cba342bc53c0283808.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 84, <br /> "title": "Slim iPhone 7, iPhone 8",
        /// <br /> "brand": "Case Mate", <br /> "model": "Slim iPhone 7, iPhone 8", <br /> "images":
        /// [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f603.png">https://images.printify.com/5853fe7dce46f30f8327f603.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f606.png">https://images.printify.com/5853fe7dce46f30f8327f606.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 85, <br /> "title": "Tough iPhone 7, IPhone 8",
        /// <br /> "brand": "Case Mate", <br /> "model": "Tough iPhone 7, IPhone 8", <br />
        /// "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5e5.png">https://images.printify.com/5853fe7dce46f30f8327f5e5.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5e8.png">https://images.printify.com/5853fe7dce46f30f8327f5e8.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 86, <br /> "title": "Slim iPhone 7 Plus, iPhone
        /// 8 Plus", <br /> "brand": "Case Mate", <br /> "model": "Slim iPhone 7 Plus, , iPhone 8
        /// Plus", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f609.png">https://images.printify.com/5853fe7dce46f30f8327f609.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f60c.png">https://images.printify.com/5853fe7dce46f30f8327f60c.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 87, <br /> "title": "Tough iPhone 7 Plus,
        /// iPhone 8 Plus", <br /> "brand": "Case Mate", <br /> "model": "Tough iPhone 7 Plus,
        /// iPhone 8 Plus", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f60f.png">https://images.printify.com/5853fe7dce46f30f8327f60f.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f612.png">https://images.printify.com/5853fe7dce46f30f8327f612.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 99, <br /> "title": "All US Phone cases", <br
        /// /> "brand": "Case Mate", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5eb.png">https://images.printify.com/5853fe7dce46f30f8327f5eb.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5ee.png">https://images.printify.com/5853fe7dce46f30f8327f5ee.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5f1.png">https://images.printify.com/5853fe7dce46f30f8327f5f1.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5f4.png">https://images.printify.com/5853fe7dce46f30f8327f5f4.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f61b.png">https://images.printify.com/5853fe7dce46f30f8327f61b.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f61e.png">https://images.printify.com/5853fe7dce46f30f8327f61e.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f615.png">https://images.printify.com/5853fe7dce46f30f8327f615.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f618.png">https://images.printify.com/5853fe7dce46f30f8327f618.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5f7.png">https://images.printify.com/5853fe7dce46f30f8327f5f7.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5fa.png">https://images.printify.com/5853fe7dce46f30f8327f5fa.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5fd.png">https://images.printify.com/5853fe7dce46f30f8327f5fd.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f600.png">https://images.printify.com/5853fe7dce46f30f8327f600.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe80ce46f30f8327f7cf.png">https://images.printify.com/5853fe80ce46f30f8327f7cf.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe80ce46f30f8327f7d7.png">https://images.printify.com/5853fe80ce46f30f8327f7d7.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f639.png">https://images.printify.com/5853fe7ece46f30f8327f639.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f63c.png">https://images.printify.com/5853fe7ece46f30f8327f63c.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f63f.png">https://images.printify.com/5853fe7ece46f30f8327f63f.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f642.png">https://images.printify.com/5853fe7ece46f30f8327f642.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f621.png">https://images.printify.com/5853fe7dce46f30f8327f621.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f624.png">https://images.printify.com/5853fe7dce46f30f8327f624.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f627.png">https://images.printify.com/5853fe7dce46f30f8327f627.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f62a.png">https://images.printify.com/5853fe7ece46f30f8327f62a.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f62d.png">https://images.printify.com/5853fe7ece46f30f8327f62d.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f630.png">https://images.printify.com/5853fe7ece46f30f8327f630.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f633.png">https://images.printify.com/5853fe7ece46f30f8327f633.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7ece46f30f8327f636.png">https://images.printify.com/5853fe7ece46f30f8327f636.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f603.png">https://images.printify.com/5853fe7dce46f30f8327f603.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f606.png">https://images.printify.com/5853fe7dce46f30f8327f606.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5e5.png">https://images.printify.com/5853fe7dce46f30f8327f5e5.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f5e8.png">https://images.printify.com/5853fe7dce46f30f8327f5e8.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f609.png">https://images.printify.com/5853fe7dce46f30f8327f609.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f60c.png">https://images.printify.com/5853fe7dce46f30f8327f60c.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f60f.png">https://images.printify.com/5853fe7dce46f30f8327f60f.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7dce46f30f8327f612.png">https://images.printify.com/5853fe7dce46f30f8327f612.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 125, <br /> "title": "Mugs", <br /> "brand":
        /// "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5853fe7bce46f30f8327f4fc.png">https://images.printify.com/5853fe7bce46f30f8327f4fc.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/58ac5d64b2439213b51b25ff.png">https://images.printify.com/58ac5d64b2439213b51b25ff.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5853fe7bce46f30f8327f4ff.png">https://images.printify.com/5853fe7bce46f30f8327f4ff.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c5c1516a342bcb8e421d242.png">https://images.printify.com/5c5c1516a342bcb8e421d242.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 268, <br /> "title": "Case Mate Slim Phone
        /// Cases", <br /> "brand": "Case Mate", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d08c85847045f00097be5b3.png">https://images.printify.com/5d08c85847045f00097be5b3.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 269, <br /> "title": "Case Mate Tough Phone
        /// Cases", <br /> "brand": "Case Mate", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d132242c1bdb8000a6e474c.png">https://images.printify.com/5d132242c1bdb8000a6e474c.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5d131fadc1bdb800125d2efd.png">https://images.printify.com/5d131fadc1bdb800125d2efd.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 277, <br /> "title": "Wall clock", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d0b31f347045f01ae2eeb1f.png">https://images.printify.com/5d0b31f347045f01ae2eeb1f.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5a033c07b8e7e328100d3c27.png">https://images.printify.com/5a033c07b8e7e328100d3c27.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 289, <br /> "title": "Latte mug", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d0a0e6047045f0189376682.png">https://images.printify.com/5d0a0e6047045f0189376682.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5a325c76b8e7e355db3449e8.png">https://images.printify.com/5a325c76b8e7e355db3449e8.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 352, <br /> "title": "Beach Towel", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5afeba40a342bcea7045d84e.png">https://images.printify.com/5afeba40a342bcea7045d84e.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 353, <br /> "title": "Tumbler 20oz", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5ad0a5baa342bc91115b6927.png">https://images.printify.com/5ad0a5baa342bc91115b6927.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 354, <br /> "title": "Tumbler 10oz", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5ad0a68ca342bc911954d928.png">https://images.printify.com/5ad0a68ca342bc911954d928.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 355, <br /> "title": "Can Holder", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5ad0a53ca342bc9114070039.png">https://images.printify.com/5ad0a53ca342bc9114070039.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 376, <br /> "title": "Sublimation Socks", <br
        /// /> "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d13450ec1bdb800125d2f0d.png">https://images.printify.com/5d13450ec1bdb800125d2f0d.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5be1ae47a342bc3390628e22.png">https://images.printify.com/5be1ae47a342bc3390628e22.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5bbc8702a342bc24e4283e2c.png">https://images.printify.com/5bbc8702a342bc24e4283e2c.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 384, <br /> "title": "Square Stickers", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5cf4f606705f1900141a667c.png">https://images.printify.com/5cf4f606705f1900141a667c.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c6685a6a342bc4c6340bf82.png">https://images.printify.com/5c6685a6a342bc4c6340bf82.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 400, <br /> "title": "Kiss-Cut Stickers", <br
        /// /> "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5cf4fabe705f190009393f38.png">https://images.printify.com/5cf4fabe705f190009393f38.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c48648aa342bc7e304661f2.png">https://images.printify.com/5c48648aa342bc7e304661f2.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c4864a2a342bc7e256c1d6c.png">https://images.printify.com/5c4864a2a342bc7e256c1d6c.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 423, <br /> "title": "Alex' Test Product (do
        /// not delete)", <br /> "brand": "Bella+Canvas", <br /> "model": "9999", <br /> "images": [
        /// <br /> " <a
        /// href="https://images.printify.com/5c8bdf3d21a6ed001111c202.png">https://images.printify.com/5c8bdf3d21a6ed001111c202.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c7565d51e58a3000964b4e2.png">https://images.printify.com/5c7565d51e58a3000964b4e2.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c8bdfa721a6ed000f1d19d2.png">https://images.printify.com/5c8bdfa721a6ed000f1d19d2.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c8be08a21a6ed00102eaa97.png">https://images.printify.com/5c8be08a21a6ed00102eaa97.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5c8be09321a6ed0014663572.png">https://images.printify.com/5c8be09321a6ed0014663572.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 425, <br /> "title": "Mug 15oz", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d0a08d647045f00097be6cd.png">https://images.printify.com/5d0a08d647045f00097be6cd.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5d0a07b547045f00083cd116.png">https://images.printify.com/5d0a07b547045f00083cd116.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cab36e06b4a8300124cea40.png">https://images.printify.com/5cab36e06b4a8300124cea40.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cab21ef6b4a83000970c497.png">https://images.printify.com/5cab21ef6b4a83000970c497.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 427, <br /> "title": "Magnets", <br /> "brand":
        /// "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d0b831a47045f02006b0b7a.png">https://images.printify.com/5d0b831a47045f02006b0b7a.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5ce534113aa847000600d60c.png">https://images.printify.com/5ce534113aa847000600d60c.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 429, <br /> "title": "Laptop Sleeve", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5d2325ebce7a9c07c221c926.png">https://images.printify.com/5d2325ebce7a9c07c221c926.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5d23233fce7a9c07c105f393.png">https://images.printify.com/5d23233fce7a9c07c105f393.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5d232340ce7a9c07c04f9aa7.png">https://images.printify.com/5d232340ce7a9c07c04f9aa7.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5d23233ece7a9c07c04f9aa3.png">https://images.printify.com/5d23233ece7a9c07c04f9aa3.png</a>"
        /// <br /> ] <br /> }, <br /> { <br /> "id": 430, <br /> "title": "Pin Buttons", <br />
        /// "brand": "Generic brand", <br /> "model": "", <br /> "images": [ <br /> " <a
        /// href="https://images.printify.com/5cfa4880cf4eed002673c8c2.png">https://images.printify.com/5cfa4880cf4eed002673c8c2.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cfa46a8cf4eed00101202d9.png">https://images.printify.com/5cfa46a8cf4eed00101202d9.png</a>",
        /// <br /> " <a
        /// href="https://images.printify.com/5cfa0db8cf4eed00101202d2.png">https://images.printify.com/5cfa0db8cf4eed00101202d2.png</a>"
        /// <br /> ] <br /> } <br /> ] <br />}
        /// </example>
        Task<PrintProvider?> GetPrintProvider(int printProviderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Gets the list of available print providers.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/catalog/print_providers.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The list of available print providers.</returns>
        /// <example>
        /// [ <br /> { <br /> "id": 1, <br /> "title": "SPOKE Custom Products", <br /> "location": {
        /// <br /> "address1": "89 Weirfield St", <br /> "address2": null, <br /> "city":
        /// "Brooklyn", <br /> "country": "US", <br /> "region": "NY", <br /> "zip": "11221-5120"
        /// <br /> } <br /> }, <br /> { <br /> "id": 2, <br /> "title": "CG Pro prints", <br />
        /// "location": { <br /> "address1": "89 Weirfield St", <br /> "address2": null, <br />
        /// "city": "Brooklyn", <br /> "country": "US", <br /> "region": "NY", <br /> "zip":
        /// "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 3, <br /> "title": "The Dream
        /// Junction ", <br /> "location": { <br /> "address1": "89 Weirfield St", <br />
        /// "address2": "", <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 5, <br />
        /// "title": "ArtGun", <br /> "location": { <br /> "address1": "89 Weirfield St", <br />
        /// "address2": "", <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 6, <br />
        /// "title": "T shirt and Sons", <br /> "location": { <br /> "address1": "89 Weirfield St",
        /// <br /> "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br />
        /// "region": "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 7,
        /// <br /> "title": "Prodigi", <br /> "location": { <br /> "address1": "89 Weirfield St",
        /// <br /> "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br />
        /// "region": "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 8,
        /// <br /> "title": "Fifth Sun", <br /> "location": { <br /> "address1": "89 Weirfield St",
        /// <br /> "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br />
        /// "region": "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 9,
        /// <br /> "title": "WPaPS", <br /> "location": { <br /> "address1": "89 Weirfield St", <br
        /// /> "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 10, <br />
        /// "title": "MWW On Demand", <br /> "location": { <br /> "address1": "89 Weirfield St", <br
        /// /> "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 14, <br />
        /// "title": "ArtsAdd", <br /> "location": { <br /> "address1": "89 Weirfield St", <br />
        /// "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 16, <br />
        /// "title": "MyLocker", <br /> "location": { <br /> "address1": "89 Weirfield St", <br />
        /// "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 20, <br />
        /// "title": "Troupe Jewelry", <br /> "location": { <br /> "address1": "89 Weirfield St",
        /// <br /> "address2": null, <br /> "city": "Brooklyn", <br /> "country": "US", <br />
        /// "region": "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 23,
        /// <br /> "title": "WOYC", <br /> "location": { <br /> "address1": "89 Weirfield St", <br
        /// /> "address2": "", <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 24, <br />
        /// "title": "Inklocker", <br /> "location": { <br /> "address1": "89 Weirfield St", <br />
        /// "address2": "", <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> }, <br /> { <br /> "id": 25, <br />
        /// "title": "DTG2Go", <br /> "location": { <br /> "address1": "89 Weirfield St", <br />
        /// "address2": "", <br /> "city": "Brooklyn", <br /> "country": "US", <br /> "region":
        /// "NY", <br /> "zip": "11221-5120" <br /> } <br /> } <br />]
        /// <code></code>
        /// </example>
        Task<List<PrintProvider>> GetPrintProviders(CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Gets the list of all print providers that fulfill orders for a specific blueprint.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/catalog/blueprints/{blueprint_id}/print_providers.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="blueprintId">The blueprint identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The list of all print providers that fulfill orders for a specific blueprint.</returns>
        /// <example>
        /// [ <br /> { <br /> "id": 3, <br /> "title": "DJ" <br /> }, <br /> { <br /> "id": 8, <br
        /// /> "title": "Fifth Sun" <br /> }, <br /> { <br /> "id": 16, <br /> "title": "MyLocker"
        /// <br /> }, <br /> { <br /> "id": 24, <br /> "title": "Inklocker" <br /> } <br />] <br />
        /// </example>
        Task<List<PrintProvider>> GetPrintProviders(int blueprintId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Gets the shipping information.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET /v1/catalog/blueprints/{blueprint_id}/print_providers/{print_provider_id}/shipping.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="blueprintId">The blueprint identifier.</param>
        /// <param name="printProviderId">The print provider identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The shipping information.</returns>
        /// <example>
        /// { <br /> "handling_time": { <br /> "value": 30, <br /> "unit": "day" <br /> }, <br />
        /// "profiles": [ <br /> { <br /> "variant_ids": [ <br /> 42716, <br /> 42717, <br /> 42718,
        /// <br /> 42719, <br /> 42720, <br /> 12144, <br /> 12143, <br /> 12142, <br /> 12145, <br
        /// /> 12146, <br /> 12150, <br /> 12149, <br /> 12148, <br /> 12151, <br /> 12152, <br />
        /// 12162, <br /> 12161, <br /> 12160, <br /> 12163, <br /> 12164, <br /> 12180, <br />
        /// 12179, <br /> 12178, <br /> 12181, <br /> 12182, <br /> 12192, <br /> 12191, <br />
        /// 12190, <br /> 12193, <br /> 12194, <br /> 11874, <br /> 11873, <br /> 11872, <br />
        /// 11875, <br /> 11876, <br /> 11892, <br /> 11891, <br /> 11890, <br /> 11893, <br />
        /// 11894, <br /> 11898, <br /> 11897, <br /> 11896, <br /> 11899, <br /> 11900, <br />
        /// 11934, <br /> 11933, <br /> 11932, <br /> 11935, <br /> 11936, <br /> 11946, <br />
        /// 11945, <br /> 11944, <br /> 11947, <br /> 11948, <br /> 11952, <br /> 11951, <br />
        /// 11950, <br /> 11953, <br /> 11954, <br /> 11958, <br /> 11957, <br /> 11956, <br />
        /// 11959, <br /> 11960, <br /> 11976, <br /> 11975, <br /> 11974, <br /> 11977, <br />
        /// 11978, <br /> 11988, <br /> 11987, <br /> 11986, <br /> 11989, <br /> 11990, <br />
        /// 12012, <br /> 12011, <br /> 12010, <br /> 12013, <br /> 12014, <br /> 12018, <br />
        /// 12017, <br /> 12016, <br /> 12019, <br /> 12020, <br /> 12024, <br /> 12023, <br />
        /// 12022, <br /> 12025, <br /> 12026, <br /> 12030, <br /> 12029, <br /> 12028, <br />
        /// 12031, <br /> 12032, <br /> 12054, <br /> 12053, <br /> 12052, <br /> 12055, <br />
        /// 12056, <br /> 12072, <br /> 12071, <br /> 12070, <br /> 12073, <br /> 12074, <br />
        /// 12102, <br /> 12101, <br /> 12100, <br /> 12103, <br /> 12104, <br /> 12126, <br />
        /// 12125, <br /> 12124, <br /> 12127, <br /> 12128 <br /> ], <br /> "first_item": { <br />
        /// "cost": 450, <br /> "currency": "USD" <br /> }, <br /> "additional_items": { <br />
        /// "cost": 0, <br /> "currency": "USD" <br /> }, <br /> "countries": [ <br /> "US" <br /> ]
        /// <br /> }, <br /> { <br /> "variant_ids": [ <br /> 42716, <br /> 42717, <br /> 42718, <br
        /// /> 42719, <br /> 42720, <br /> 12144, <br /> 12143, <br /> 12142, <br /> 12145, <br />
        /// 12146, <br /> 12150, <br /> 12149, <br /> 12148, <br /> 12151, <br /> 12152, <br />
        /// 12162, <br /> 12161, <br /> 12160, <br /> 12163, <br /> 12164, <br /> 12180, <br />
        /// 12179, <br /> 12178, <br /> 12181, <br /> 12182, <br /> 12192, <br /> 12191, <br />
        /// 12190, <br /> 12193, <br /> 12194, <br /> 11874, <br /> 11873, <br /> 11872, <br />
        /// 11875, <br /> 11876, <br /> 11892, <br /> 11891, <br /> 11890, <br /> 11893, <br />
        /// 11894, <br /> 11898, <br /> 11897, <br /> 11896, <br /> 11899, <br /> 11900, <br />
        /// 11934, <br /> 11933, <br /> 11932, <br /> 11935, <br /> 11936, <br /> 11946, <br />
        /// 11945, <br /> 11944, <br /> 11947, <br /> 11948, <br /> 11952, <br /> 11951, <br />
        /// 11950, <br /> 11953, <br /> 11954, <br /> 11958, <br /> 11957, <br /> 11956, <br />
        /// 11959, <br /> 11960, <br /> 11976, <br /> 11975, <br /> 11974, <br /> 11977, <br />
        /// 11978, <br /> 11988, <br /> 11987, <br /> 11986, <br /> 11989, <br /> 11990, <br />
        /// 12012, <br /> 12011, <br /> 12010, <br /> 12013, <br /> 12014, <br /> 12018, <br />
        /// 12017, <br /> 12016, <br /> 12019, <br /> 12020, <br /> 12024, <br /> 12023, <br />
        /// 12022, <br /> 12025, <br /> 12026, <br /> 12030, <br /> 12029, <br /> 12028, <br />
        /// 12031, <br /> 12032, <br /> 12054, <br /> 12053, <br /> 12052, <br /> 12055, <br />
        /// 12056, <br /> 12072, <br /> 12071, <br /> 12070, <br /> 12073, <br /> 12074, <br />
        /// 12102, <br /> 12101, <br /> 12100, <br /> 12103, <br /> 12104, <br /> 12126, <br />
        /// 12125, <br /> 12124, <br /> 12127, <br /> 12128 <br /> ], <br /> "first_item": { <br />
        /// "cost": 650, <br /> "currency": "USD" <br /> }, <br /> "additional_items": { <br />
        /// "cost": 0, <br /> "currency": "USD" <br /> }, <br /> "countries": [ <br /> "CA", <br />
        /// "AU", <br /> "AT", <br /> "BE", <br /> "BG", <br /> "HR", <br /> "CY", <br /> "CZ", <br
        /// /> "DK", <br /> "EE", <br /> "FI", <br /> "FR", <br /> "DE", <br /> "GR", <br /> "HU",
        /// <br /> "IS", <br /> "IE", <br /> "IT", <br /> "LT", <br /> "LV", <br /> "LU", <br />
        /// "MT", <br /> "NL", <br /> "NO", <br /> "PT", <br /> "PL", <br /> "RO", <br /> "SK", <br
        /// /> "SI", <br /> "ES", <br /> "SE", <br /> "CH", <br /> "TR", <br /> "GB", <br /> "GI",
        /// <br /> "AX" <br /> ] <br /> }, <br /> { <br /> "variant_ids": [ <br /> 42716, <br />
        /// 42717, <br /> 42718, <br /> 42719, <br /> 42720, <br /> 12144, <br /> 12143, <br />
        /// 12142, <br /> 12145, <br /> 12146, <br /> 12150, <br /> 12149, <br /> 12148, <br />
        /// 12151, <br /> 12152, <br /> 12162, <br /> 12161, <br /> 12160, <br /> 12163, <br />
        /// 12164, <br /> 12180, <br /> 12179, <br /> 12178, <br /> 12181, <br /> 12182, <br />
        /// 12192, <br /> 12191, <br /> 12190, <br /> 12193, <br /> 12194, <br /> 11874, <br />
        /// 11873, <br /> 11872, <br /> 11875, <br /> 11876, <br /> 11892, <br /> 11891, <br />
        /// 11890, <br /> 11893, <br /> 11894, <br /> 11898, <br /> 11897, <br /> 11896, <br />
        /// 11899, <br /> 11900, <br /> 11934, <br /> 11933, <br /> 11932, <br /> 11935, <br />
        /// 11936, <br /> 11946, <br /> 11945, <br /> 11944, <br /> 11947, <br /> 11948, <br />
        /// 11952, <br /> 11951, <br /> 11950, <br /> 11953, <br /> 11954, <br /> 11958, <br />
        /// 11957, <br /> 11956, <br /> 11959, <br /> 11960, <br /> 11976, <br /> 11975, <br />
        /// 11974, <br /> 11977, <br /> 11978, <br /> 11988, <br /> 11987, <br /> 11986, <br />
        /// 11989, <br /> 11990, <br /> 12012, <br /> 12011, <br /> 12010, <br /> 12013, <br />
        /// 12014, <br /> 12018, <br /> 12017, <br /> 12016, <br /> 12019, <br /> 12020, <br />
        /// 12024, <br /> 12023, <br /> 12022, <br /> 12025, <br /> 12026, <br /> 12030, <br />
        /// 12029, <br /> 12028, <br /> 12031, <br /> 12032, <br /> 12054, <br /> 12053, <br />
        /// 12052, <br /> 12055, <br /> 12056, <br /> 12072, <br /> 12071, <br /> 12070, <br />
        /// 12073, <br /> 12074, <br /> 12102, <br /> 12101, <br /> 12100, <br /> 12103, <br />
        /// 12104, <br /> 12126, <br /> 12125, <br /> 12124, <br /> 12127, <br /> 12128 <br /> ],
        /// <br /> "first_item": { <br /> "cost": 1100, <br /> "currency": "USD" <br /> }, <br />
        /// "additional_items": { <br /> "cost": 0, <br /> "currency": "USD" <br /> }, <br />
        /// "countries": [ <br /> "REST_OF_THE_WORLD" <br /> ] <br /> } <br /> ] <br />}
        /// <code></code>
        /// </example>
        Task<Shipping?> GetShipping(int blueprintId, int printProviderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Gets the list of variants of a blueprint from a specific print provider.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/catalog/blueprints/{blueprint_id}/print_providers/{print_provider_id}/variants.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="blueprintId">The blueprint identifier.</param>
        /// <param name="printProviderId">The print provider identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The list of variants of a blueprint from a specific print provider.</returns>
        /// <example>
        /// { <br /> "id": 3, <br /> "title": "DJ", <br /> "variants": [ <br /> { <br /> "id":
        /// 17390, <br /> "title": "Heather Grey / XS", <br /> "options": { <br /> "color": "Heather
        /// Grey", <br /> "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17426, <br /> "title": "Solid Black / XS", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "XS" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 3995, <br />
        /// "width": 3153 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 3995, <br
        /// /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17435, <br />
        /// "title": "Solid Scarlet / XS", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17444, <br /> "title": "Solid Cool Blue / XS", <br /> "options": { <br />
        /// "color": "Solid Cool Blue", <br /> "size": "XS" <br /> }, <br /> "placeholders": [ <br
        /// /> { <br /> "position": "back", <br /> "height": 3995, <br /> "width": 3153 <br /> },
        /// <br /> { <br /> "position": "front", <br /> "height": 3995, <br /> "width": 3153 <br />
        /// } <br /> ] <br /> }, <br /> { <br /> "id": 17453, <br /> "title": "Solid Cream / XS",
        /// <br /> "options": { <br /> "color": "Solid Cream", <br /> "size": "XS" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 3995, <br />
        /// "width": 3153 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 3995, <br
        /// /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17462, <br />
        /// "title": "Solid Dark Chocolate / XS", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17480, <br /> "title": "Solid Heavy Metal / XS", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "XS" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 3995, <br />
        /// "width": 3153 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 3995, <br
        /// /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17489, <br />
        /// "title": "Solid Indigo / XS", <br /> "options": { <br /> "color": "Solid Indigo", <br />
        /// "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17516, <br /> "title": "Solid Light Blue / XS", <br /> "options": { <br />
        /// "color": "Solid Light Blue", <br /> "size": "XS" <br /> }, <br /> "placeholders": [ <br
        /// /> { <br /> "position": "back", <br /> "height": 3995, <br /> "width": 3153 <br /> },
        /// <br /> { <br /> "position": "front", <br /> "height": 3995, <br /> "width": 3153 <br />
        /// } <br /> ] <br /> }, <br /> { <br /> "id": 17552, <br /> "title": "Solid Maroon / XS",
        /// <br /> "options": { <br /> "color": "Solid Maroon", <br /> "size": "XS" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 3995, <br />
        /// "width": 3153 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 3995, <br
        /// /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17588, <br />
        /// "title": "Solid Red / XS", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17597, <br /> "title": "Solid Royal / XS", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17606, <br /> "title": "Solid Sand / XS", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "XS" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 3995, <br />
        /// "width": 3153 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 3995, <br
        /// /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17642, <br />
        /// "title": "Solid White / XS", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "XS" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 3995, <br /> "width": 3153 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 3995, <br /> "width": 3153 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17391, <br /> "title": "Heather Grey / S", <br /> "options": { <br /> "color":
        /// "Heather Grey", <br /> "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17427, <br /> "title": "Solid Black / S", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "S" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 4563, <br />
        /// "width": 3602 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 4563, <br
        /// /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17436, <br />
        /// "title": "Solid Scarlet / S", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17445, <br /> "title": "Solid Cool Blue / S", <br /> "options": { <br />
        /// "color": "Solid Cool Blue", <br /> "size": "S" <br /> }, <br /> "placeholders": [ <br />
        /// { <br /> "position": "back", <br /> "height": 4563, <br /> "width": 3602 <br /> }, <br
        /// /> { <br /> "position": "front", <br /> "height": 4563, <br /> "width": 3602 <br /> }
        /// <br /> ] <br /> }, <br /> { <br /> "id": 17454, <br /> "title": "Solid Cream / S", <br
        /// /> "options": { <br /> "color": "Solid Cream", <br /> "size": "S" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 4563, <br />
        /// "width": 3602 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 4563, <br
        /// /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17463, <br />
        /// "title": "Solid Dark Chocolate / S", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17481, <br /> "title": "Solid Heavy Metal / S", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "S" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 4563, <br />
        /// "width": 3602 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 4563, <br
        /// /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17490, <br />
        /// "title": "Solid Indigo / S", <br /> "options": { <br /> "color": "Solid Indigo", <br />
        /// "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17517, <br /> "title": "Solid Light Blue / S", <br /> "options": { <br /> "color":
        /// "Solid Light Blue", <br /> "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br
        /// /> "position": "back", <br /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> {
        /// <br /> "position": "front", <br /> "height": 4563, <br /> "width": 3602 <br /> } <br />
        /// ] <br /> }, <br /> { <br /> "id": 17553, <br /> "title": "Solid Maroon / S", <br />
        /// "options": { <br /> "color": "Solid Maroon", <br /> "size": "S" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 4563, <br />
        /// "width": 3602 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 4563, <br
        /// /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17589, <br />
        /// "title": "Solid Red / S", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17598, <br /> "title": "Solid Royal / S", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17607, <br /> "title": "Solid Sand / S", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "S" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 4563, <br />
        /// "width": 3602 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 4563, <br
        /// /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17643, <br />
        /// "title": "Solid White / S", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "S" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 4563, <br /> "width": 3602 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 4563, <br /> "width": 3602 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17392, <br /> "title": "Heather Grey / M", <br /> "options": { <br /> "color":
        /// "Heather Grey", <br /> "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17428, <br /> "title": "Solid Black / M", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "M" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5131, <br />
        /// "width": 4051 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5131, <br
        /// /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17437, <br />
        /// "title": "Solid Scarlet / M", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17446, <br /> "title": "Solid Cool Blue / M", <br /> "options": { <br />
        /// "color": "Solid Cool Blue", <br /> "size": "M" <br /> }, <br /> "placeholders": [ <br />
        /// { <br /> "position": "back", <br /> "height": 5131, <br /> "width": 4051 <br /> }, <br
        /// /> { <br /> "position": "front", <br /> "height": 5131, <br /> "width": 4051 <br /> }
        /// <br /> ] <br /> }, <br /> { <br /> "id": 17455, <br /> "title": "Solid Cream / M", <br
        /// /> "options": { <br /> "color": "Solid Cream", <br /> "size": "M" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5131, <br />
        /// "width": 4051 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5131, <br
        /// /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17464, <br />
        /// "title": "Solid Dark Chocolate / M", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17482, <br /> "title": "Solid Heavy Metal / M", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "M" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5131, <br />
        /// "width": 4051 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5131, <br
        /// /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17491, <br />
        /// "title": "Solid Indigo / M", <br /> "options": { <br /> "color": "Solid Indigo", <br />
        /// "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17518, <br /> "title": "Solid Light Blue / M", <br /> "options": { <br /> "color":
        /// "Solid Light Blue", <br /> "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br
        /// /> "position": "back", <br /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> {
        /// <br /> "position": "front", <br /> "height": 5131, <br /> "width": 4051 <br /> } <br />
        /// ] <br /> }, <br /> { <br /> "id": 17554, <br /> "title": "Solid Maroon / M", <br />
        /// "options": { <br /> "color": "Solid Maroon", <br /> "size": "M" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5131, <br />
        /// "width": 4051 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5131, <br
        /// /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17590, <br />
        /// "title": "Solid Red / M", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17599, <br /> "title": "Solid Royal / M", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17608, <br /> "title": "Solid Sand / M", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "M" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5131, <br />
        /// "width": 4051 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5131, <br
        /// /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17644, <br />
        /// "title": "Solid White / M", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "M" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5131, <br /> "width": 4051 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5131, <br /> "width": 4051 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17393, <br /> "title": "Heather Grey / L", <br /> "options": { <br /> "color":
        /// "Heather Grey", <br /> "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17429, <br /> "title": "Solid Black / L", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "L" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17438, <br />
        /// "title": "Solid Scarlet / L", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17447, <br /> "title": "Solid Cool Blue / L", <br /> "options": { <br />
        /// "color": "Solid Cool Blue", <br /> "size": "L" <br /> }, <br /> "placeholders": [ <br />
        /// { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br
        /// /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> }
        /// <br /> ] <br /> }, <br /> { <br /> "id": 17456, <br /> "title": "Solid Cream / L", <br
        /// /> "options": { <br /> "color": "Solid Cream", <br /> "size": "L" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17465, <br />
        /// "title": "Solid Dark Chocolate / L", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17483, <br /> "title": "Solid Heavy Metal / L", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "L" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17492, <br />
        /// "title": "Solid Indigo / L", <br /> "options": { <br /> "color": "Solid Indigo", <br />
        /// "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17519, <br /> "title": "Solid Light Blue / L", <br /> "options": { <br /> "color":
        /// "Solid Light Blue", <br /> "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br
        /// /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> {
        /// <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br />
        /// ] <br /> }, <br /> { <br /> "id": 17555, <br /> "title": "Solid Maroon / L", <br />
        /// "options": { <br /> "color": "Solid Maroon", <br /> "size": "L" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17591, <br />
        /// "title": "Solid Red / L", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17600, <br /> "title": "Solid Royal / L", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17609, <br /> "title": "Solid Sand / L", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "L" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17645, <br />
        /// "title": "Solid White / L", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "L" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17394, <br /> "title": "Heather Grey / XL", <br /> "options": { <br /> "color":
        /// "Heather Grey", <br /> "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17430, <br /> "title": "Solid Black / XL", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17439, <br />
        /// "title": "Solid Scarlet / XL", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17448, <br /> "title": "Solid Cool Blue / XL", <br /> "options": { <br />
        /// "color": "Solid Cool Blue", <br /> "size": "XL" <br /> }, <br /> "placeholders": [ <br
        /// /> { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> },
        /// <br /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br />
        /// } <br /> ] <br /> }, <br /> { <br /> "id": 17457, <br /> "title": "Solid Cream / XL",
        /// <br /> "options": { <br /> "color": "Solid Cream", <br /> "size": "XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17466, <br />
        /// "title": "Solid Dark Chocolate / XL", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17484, <br /> "title": "Solid Heavy Metal / XL", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17493, <br />
        /// "title": "Solid Indigo / XL", <br /> "options": { <br /> "color": "Solid Indigo", <br />
        /// "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17520, <br /> "title": "Solid Light Blue / XL", <br /> "options": { <br />
        /// "color": "Solid Light Blue", <br /> "size": "XL" <br /> }, <br /> "placeholders": [ <br
        /// /> { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> },
        /// <br /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br />
        /// } <br /> ] <br /> }, <br /> { <br /> "id": 17556, <br /> "title": "Solid Maroon / XL",
        /// <br /> "options": { <br /> "color": "Solid Maroon", <br /> "size": "XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17592, <br />
        /// "title": "Solid Red / XL", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17601, <br /> "title": "Solid Royal / XL", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17610, <br /> "title": "Solid Sand / XL", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17646, <br />
        /// "title": "Solid White / XL", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17395, <br /> "title": "Heather Grey / 2XL", <br /> "options": { <br /> "color":
        /// "Heather Grey", <br /> "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17431, <br /> "title": "Solid Black / 2XL", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "2XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17440, <br />
        /// "title": "Solid Scarlet / 2XL", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17449, <br /> "title": "Solid Cool Blue / 2XL", <br /> "options": { <br
        /// /> "color": "Solid Cool Blue", <br /> "size": "2XL" <br /> }, <br /> "placeholders": [
        /// <br /> { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br />
        /// }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br
        /// /> } <br /> ] <br /> }, <br /> { <br /> "id": 17458, <br /> "title": "Solid Cream /
        /// 2XL", <br /> "options": { <br /> "color": "Solid Cream", <br /> "size": "2XL" <br /> },
        /// <br /> "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700,
        /// <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17467, <br />
        /// "title": "Solid Dark Chocolate / 2XL", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17485, <br /> "title": "Solid Heavy Metal / 2XL", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "2XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17494, <br />
        /// "title": "Solid Indigo / 2XL", <br /> "options": { <br /> "color": "Solid Indigo", <br
        /// /> "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17521, <br /> "title": "Solid Light Blue / 2XL", <br /> "options": { <br
        /// /> "color": "Solid Light Blue", <br /> "size": "2XL" <br /> }, <br /> "placeholders": [
        /// <br /> { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br />
        /// }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br
        /// /> } <br /> ] <br /> }, <br /> { <br /> "id": 17557, <br /> "title": "Solid Maroon /
        /// 2XL", <br /> "options": { <br /> "color": "Solid Maroon", <br /> "size": "2XL" <br /> },
        /// <br /> "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700,
        /// <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17593, <br />
        /// "title": "Solid Red / 2XL", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17602, <br /> "title": "Solid Royal / 2XL", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17611, <br /> "title": "Solid Sand / 2XL", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "2XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17647, <br />
        /// "title": "Solid White / 2XL", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "2XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17396, <br /> "title": "Heather Grey / 3XL", <br /> "options": { <br /> "color":
        /// "Heather Grey", <br /> "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17432, <br /> "title": "Solid Black / 3XL", <br />
        /// "options": { <br /> "color": "Solid Black", <br /> "size": "3XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17441, <br />
        /// "title": "Solid Scarlet / 3XL", <br /> "options": { <br /> "color": "Solid Scarlet", <br
        /// /> "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17450, <br /> "title": "Solid Cool Blue / 3XL", <br /> "options": { <br
        /// /> "color": "Solid Cool Blue", <br /> "size": "3XL" <br /> }, <br /> "placeholders": [
        /// <br /> { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br />
        /// }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br
        /// /> } <br /> ] <br /> }, <br /> { <br /> "id": 17459, <br /> "title": "Solid Cream /
        /// 3XL", <br /> "options": { <br /> "color": "Solid Cream", <br /> "size": "3XL" <br /> },
        /// <br /> "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700,
        /// <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17468, <br />
        /// "title": "Solid Dark Chocolate / 3XL", <br /> "options": { <br /> "color": "Solid Dark
        /// Chocolate", <br /> "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17486, <br /> "title": "Solid Heavy Metal / 3XL", <br />
        /// "options": { <br /> "color": "Solid Heavy Metal", <br /> "size": "3XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17495, <br />
        /// "title": "Solid Indigo / 3XL", <br /> "options": { <br /> "color": "Solid Indigo", <br
        /// /> "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position":
        /// "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br />
        /// { <br /> "id": 17522, <br /> "title": "Solid Light Blue / 3XL", <br /> "options": { <br
        /// /> "color": "Solid Light Blue", <br /> "size": "3XL" <br /> }, <br /> "placeholders": [
        /// <br /> { <br /> "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br />
        /// }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br
        /// /> } <br /> ] <br /> }, <br /> { <br /> "id": 17558, <br /> "title": "Solid Maroon /
        /// 3XL", <br /> "options": { <br /> "color": "Solid Maroon", <br /> "size": "3XL" <br /> },
        /// <br /> "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700,
        /// <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17594, <br />
        /// "title": "Solid Red / 3XL", <br /> "options": { <br /> "color": "Solid Red", <br />
        /// "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br />
        /// "id": 17603, <br /> "title": "Solid Royal / 3XL", <br /> "options": { <br /> "color":
        /// "Solid Royal", <br /> "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br />
        /// "position": "back", <br /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br
        /// /> "position": "front", <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ]
        /// <br /> }, <br /> { <br /> "id": 17612, <br /> "title": "Solid Sand / 3XL", <br />
        /// "options": { <br /> "color": "Solid Sand", <br /> "size": "3XL" <br /> }, <br />
        /// "placeholders": [ <br /> { <br /> "position": "back", <br /> "height": 5700, <br />
        /// "width": 4500 <br /> }, <br /> { <br /> "position": "front", <br /> "height": 5700, <br
        /// /> "width": 4500 <br /> } <br /> ] <br /> }, <br /> { <br /> "id": 17648, <br />
        /// "title": "Solid White / 3XL", <br /> "options": { <br /> "color": "Solid White", <br />
        /// "size": "3XL" <br /> }, <br /> "placeholders": [ <br /> { <br /> "position": "back", <br
        /// /> "height": 5700, <br /> "width": 4500 <br /> }, <br /> { <br /> "position": "front",
        /// <br /> "height": 5700, <br /> "width": 4500 <br /> } <br /> ] <br /> } <br /> ] <br />}
        /// </example>
        Task<List<Variant>> GetVariants(int blueprintId, int printProviderId, CancellationToken cancellationToken = default);
    }
}
