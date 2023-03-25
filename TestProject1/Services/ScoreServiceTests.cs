using NUnit.Framework;
using Moq;
using LogRegPage.Models;
using LogRegPage.Repositories;
using System.Linq;
using System.Collections.Generic;
/*[Test]
public void TestUpdate()
{
// Arrange
var score = new Score { Id = 1, ScoreGameOne = 10};

// Act
var result = _scoreRepository.Update(score);

// Assert
Assert.IsTrue(result);
_mockGeoQuestContext.Verify(x => x.Update(score), Times.Once);
_mockGeoQuestContext.Verify(x => x.SaveChanges(), Times.Once);
}*/

[TestFixture]
public class ScoreRepositoryTests
{
    private Mock<GeoQuestContext> _mockContext;
    private ScoreRepository _scoreRepo;

    [SetUp]
    public void Setup()
    {
        _mockContext = new Mock<GeoQuestContext>();
        _scoreRepo = new ScoreRepository(_mockContext.Object);
    }

    [Test]
    public void Update_ShouldCallUpdateAndSaveChanges()
    {
        // Arrange
        var score = new Score { Id = 1, ScoreGameOne = 100 };

        // Act
        _scoreRepo.Update(score);

        // Assert
        _mockContext.Verify(x => x.Update(score), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }

    [Test]
    public void FindScoreByUserId_ShouldReturnScore()
    {
        // Arrange.
        var userid = 1;
        var score = new Score { Id = userid, ScoreGameOne = 100 };
        var scorelist = new List<Score> { score }.AsQueryable();

        // Act
        var foo = _scoreRepo.FindScoreByUserId(List< score > );

        // Assert
        Assert.IsNotNull(foo);
        Assert.AreEqual(foo.Id, scorelist);
       /* // arrange
        var userid = 1;
        var score = new score { id = userid, scoregameone = 100 };
        var scorelist = new list<score> { score }.asqueryable();

        _mockcontext.setup(x => x.scores).returns<string>(str => scorelist);

        // act
        var result = _scorerepo.findscorebyuserid(userid);

        // assert
        assert.areequal(score, result);
        _mockcontext.verify(x => x.scores, times.once);*/
    }

    [Test]
    public void Delete_ShouldCallRemoveAndSaveChanges()
    {
        // Arrange
        var score = new Score { Id = 1, ScoreGameOne = 100 };

        // Act
        _scoreRepo.Delete(score);

        // Assert
        _mockContext.Verify(x => x.Scores.Remove(score), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }
}